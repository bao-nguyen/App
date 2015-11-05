namespace Systemt
{
    public class HoatChatChinhDTO
    {
        #region Thuộc tính

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string maHoatChatChinh;

        public string MaHoatChatChinh
        {
            get { return maHoatChatChinh; }
            set { maHoatChatChinh = value; }
        }
        private string tenHoatChatChinh;

        public string TenHoatChatChinh
        {
            get { return tenHoatChatChinh; }
            set { tenHoatChatChinh = value; }
        }
        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        #endregion Thuộc tính

        public HoatChatChinhDTO()
        {
            this.id = 0;
            this.maHoatChatChinh = this.tenHoatChatChinh = this.ghiChu = "";
        }
    }
}
