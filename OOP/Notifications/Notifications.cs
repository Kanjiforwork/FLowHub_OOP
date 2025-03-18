public class Notification
{
    public string TieuDe { get; set; }
    public string NguoiGui { get; set; }
    public DateTime ThoiGian { get; set; }
    public string NoiDung { get; set; }
    public bool DaDoc { get; set; }

    public Notification(string tieuDe, string nguoiGui, DateTime thoiGian, string noiDung, bool daDoc)
    {
        TieuDe = tieuDe;
        NguoiGui = nguoiGui;
        ThoiGian = thoiGian;
        NoiDung = noiDung;
        DaDoc = daDoc;
    }
}