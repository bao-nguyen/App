namespace Systemt
{
    public class PhanHeDTO
    {
        #region Thuộc tính

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string maPhanHe;

        public string MaPhanHe
        {
            get { return maPhanHe; }
            set { maPhanHe = value; }
        }
        private string tenPhanHe;

        public string TenPhanHe
        {
            get { return tenPhanHe; }
            set { tenPhanHe = value; }
        }

        #endregion Thuộc tính

        public PhanHeDTO()
        {
            this.id = 0;
            this.maPhanHe = this.tenPhanHe = "";
        }
    }
}
