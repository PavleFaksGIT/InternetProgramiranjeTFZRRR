SqlConnection mKonekcija;
SqlCommand Komanda;
SqlTransaction mTransakcija = null;
try
{
mKonekcija = pKonekcija.DajKonekciju();
// aktivan kod
// povezivanje
Komanda = new SqlCommand();
Komanda.Connection = mKonekcija;
Komanda = mKonekcija.CreateCommand();
// pokretanje
// NE TREBA OPEN JER DOBIJAMO OTVORENU KONEKCIJU KROZ KONSTRUKTOR
// mKonekcija.Open();
mTransakcija = mKonekcija.BeginTransaction();
Komanda.Transaction = mTransakcija;
Komanda.CommandText = Upit;
Komanda.ExecuteNonQuery();
mTransakcija.Commit();
uspeh = true;
}
catch
{
mTransakcija.Rollback();