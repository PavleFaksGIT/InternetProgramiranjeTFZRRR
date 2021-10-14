public int DajUkupanBrojStudenataZaSmer(string SifraSmera)
{
int UkupnoStudenata = 0;
DataSet dsPodaci = new DataSet();
SqlCommand Komanda = new SqlCommand("DajUkupanBrojStudenataNaSmeru", pSQLConnection);
Komanda.CommandType = CommandType.StoredProcedure;
Komanda.Parameters.Add("@SifraSmera", SqlDbType.NVarChar).Value = SifraSmera;
SqlDataAdapter da = new SqlDataAdapter();
da.SelectCommand = Komanda;
da.Fill(dsPodaci);
UkupnoStudenata = int.Parse(dsPodaci.Tables[0].Rows[0].ItemArray[0].ToString());
return UkupnoStudenata;
}