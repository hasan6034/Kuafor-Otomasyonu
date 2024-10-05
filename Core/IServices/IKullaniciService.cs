using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.IServices
{
    public interface IKullaniciService
    {
        KullanicilarDTO KullaniciGiris(string kulAdi, string kulSifre);
    }
}
