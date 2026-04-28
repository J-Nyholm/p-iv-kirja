public class DiaryEntry
{
    public int Id { get; set; }
    public DateTime Pvm { get; set; }
    public string Otsikko { get; set; }
    public string Sisalto { get; set; }

    public DiaryEntry(int id, string otsikko, string sisalto)
    {
        Id = id;
        Pvm = DateTime.Now;
        Otsikko = otsikko;
        Sisalto = sisalto;
    }
}