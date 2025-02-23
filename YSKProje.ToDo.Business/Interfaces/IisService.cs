﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Business.Interfaces
{
    public interface IisService : IGenericService<Is>
    {
        List<Is> GetirVaciblikTamamlanmayan();
        List<Is> GetirButunCedvellerle();
         Is GetirVaciblikIdIle(int id);
        List<Is> GetirAppUserId(int id);
         Is GetirRaporlarileId(int id);

        List<Is> GetirButunCedvellerle(Expression<Func<Is, bool>> filter);

         List<Is> GetiButunCedvelTamamlanmayan(out int toplamSayfa, int userid, int aktseyfe=1);
        int GetirIsSayiTamamlananAppUserIdile(int id);
        int GetirIsSayiTamamlanmasiGerekenAppUserIdile(int id);
        int GetirIsciElaveEdilmeyiGozleyenIsSayi();
        int GetirIsTamamlanmisSayi();
    }
}
