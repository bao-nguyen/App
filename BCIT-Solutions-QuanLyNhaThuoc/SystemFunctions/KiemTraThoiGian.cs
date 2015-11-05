using System;

namespace SystemFunctions
{
    public class KiemTraThoiGian
    {
        public bool KiemTraKhoangThoiGianDMY(DateTime dBatDau, DateTime dKetThuc)
        {
            DateTime homNay = DateTime.Now;
            bool kqNgayBatDau = false;
            bool kqNgayKetThuc= false;
            if (homNay.Year < dBatDau.Year || homNay.Year > dKetThuc.Year)
                return false;
            else
            {
                if (homNay.Year == dBatDau.Year)
                {
                    if (homNay.Month < dBatDau.Month)
                    {
                        return false;
                    }
                    else
                    {
                        if (homNay.Day < dBatDau.Day)
                        {
                            return false;
                        }
                        else
                        {
                            kqNgayBatDau = true;
                        }
                    }
                }

                if (homNay.Year == dKetThuc.Year)
                {
                    if (homNay.Month > dKetThuc.Month)
                    {
                        return false;
                    }
                    else
                    {
                        if (homNay.Day > dKetThuc.Day)
                        {
                            return false;
                        }
                        else
                        {
                            kqNgayKetThuc = true;
                        }
                    }
                }
                if(kqNgayBatDau && kqNgayKetThuc)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
