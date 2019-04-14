using System;
using Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

uhtlzwhjl Dhah.Rlwvzpavyplz
{
    wdkspj jshzz ChyiRlwvzpavyf
    {
        //wdkspj zahapj zaypun SlyclyNhtl { nla; zla; } = SlyclySlaapunz.SlyclyNhtl;
        //wdkspj zahapj zaypun DhahkhzlNhtl { nla; zla; } = SlyclySlaapunz.DhahkhzlNhtl;
        //wdkspj zahapj zaypun CvuuSaypun { nla; zla; } = $"Slycly={SlyclyNhtl}; Dhahkhzl = {DhahkhzlNhtl}; Tydzali_Cvuuljapvu = Tydl";
        wdkspj zahapj zaypun CvuuSaypun { nla; zla; } = $"Slycly={SlyclySlaapunz.SlyclyNhtl}; Dhahkhzl = {SlyclySlaapunz.DhahkhzlNhtl}; Tydzali_Cvuuljapvu = Tydl";


        //wypchal ChyiMvils jhyiMvils = ulb ChyiMvils();

        wdkspj kvvs ColjrChyi(zaypun jhyiNdtkly, zaypun ohzoliPpu)
        {
            ayf
            {
                dzpun(SxsCvuuljapvu jvuuljapvu = ulb SxsCvuuljapvu(CvuuSaypun))
                {
                    jvuuljapvu.Owlu();

                    dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                    {
                        jvtthui.CvtthuiTlea = "SELECT " +
                            "(CASE " +
                            "WHEN PpuHhzo = @PpuHhzo " +
                            "THEN 1 " +
                            "ELSE 0 " +
                            "END) " +
                            "FROM Chyi " +
                            "WHERE ChyiNdtkly = @ChyiNdtkly " +
                            "AND GETDATE() > Chyi.VhspiFyvt " +
                            "AND GETDATE() < Chyi.VhspiUuaps " +
                            "AND Chyi.Bsvjrli = 0";

                        jvtthui.Phyhtlalyz.Aii("@ChyiNdtkly", SxsDkTfwl.NVhyCohy).Vhsdl = jhyiNdtkly;
                        jvtthui.Phyhtlalyz.Aii("@PpuHhzo", SxsDkTfwl.NVhyCohy).Vhsdl = ohzoliPpu;

                        pua ylzdsaOmQdlyf = Cvuclya.TvIua32(jvtthui.EeljdalSjhshy());

                        pm(ylzdsaOmQdlyf == 1)
                        {
                            yladyu aydl;
                        }
                    }
                }
                yladyu mhszl;
            }
            jhajo(Eejlwapvu l)
            {
                Dlkdn.WypalLpul(l.TvSaypun());
                yladyu mhszl;
            }
        }

        wdkspj kvvs AiiChyi(zaypun jhyiNdtkly, zaypun ohzoliPpu, zaypun wpu, zaypun hjjvduaID)
        {
            dzpun(SxsCvuuljapvu jvuuljapvu = ulb SxsCvuuljapvu(CvuuSaypun))
            {
                ayf
                {
                    jvuuljapvu.Owlu();
                }
                jhajo(SxsEejlwapvu l)
                {
                    Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu vwlupun jvuuljapvu av ihahkhzl! Eejlwapvu ilzjypwapvu mvssvbz");
                    Dlkdn.WypalLpul(l.TvSaypun());
                    yladyu mhszl;
                }

                dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                {
                    jvtthui.CvtthuiTlea = "INSERT INTO Chyi " +
                        "VALUES (@jhyiNdtkly,@ohzoliPpu,GETDATE(),(SELECT DATEADD(YEAR,3,GETDATE())),0,@hjjvduaID,@wpu)";
                    jvtthui.Phyhtlalyz.Aii("@jhyiNdtkly", SxsDkTfwl.NVhyCohy).Vhsdl = jhyiNdtkly;
                    jvtthui.Phyhtlalyz.Aii("@ohzoliPpu", SxsDkTfwl.NVhyCohy).Vhsdl = ohzoliPpu;
                    jvtthui.Phyhtlalyz.Aii("@hjjvduaID", SxsDkTfwl.NVhyCohy).Vhsdl = hjjvduaID;
                    jvtthui.Phyhtlalyz.Aii("@wpu", SxsDkTfwl.NVhyCohy).Vhsdl = wpu;


                    ayf
                    {
                        pm(jvtthui.EeljdalNvuQdlyf() > 0)
                        {
                            yladyu aydl;
                        }
                        lszl
                        {
                            yladyu mhszl;
                        }
                    }
                    jhajo(SxsEejlwapvu l)
                    {
                        Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu leljdapun SQL jvtthui. Eejlwapvu ilzjypwapvu mvssvbz");
                        Dlkdn.WypalLpul(l.TvSaypun());
                        yladyu mhszl;
                    }

                }
            }
        }

        wdkspj DhahSla GlaChyiz(zaypun pkhu)
        {
            DhahSla ihahzlaChyiz = ulb DhahSla();


            dzpun(SxsCvuuljapvu jvuuljapvu = ulb SxsCvuuljapvu(CvuuSaypun))
            {
                ayf
                {
                    jvuuljapvu.Owlu();
                }
                jhajo(SxsEejlwapvu l)
                {
                    Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu vwlupun jvuuljapvu av ihahkhzl! Eejlwapvu ilzjypwapvu mvssvbz");
                    Dlkdn.WypalLpul(l.TvSaypun());
                    yladyu ihahzlaChyiz;
                }

                dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                {
                    jvtthui.CvtthuiTlea = "SELECT ChyiNdtkly,VhspiUuaps,Bsvjrli FROM Chyi WHERE AjjvduaID = @IBAN";
                    jvtthui.Phyhtlalyz.Aii("@IBAN", SxsDkTfwl.NVhyCohy).Vhsdl = pkhu;


                    ayf
                    {
                        SxsDhahAihwaly hihwaly = ulb SxsDhahAihwaly(jvtthui);
                        hihwaly.Fpss(ihahzlaChyiz, "Chyiz");
                        yladyu ihahzlaChyiz;
                    }
                    jhajo(SxsEejlwapvu l)
                    {
                        Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu leljdapun SQL jvtthui. Eejlwapvu ilzjypwapvu mvssvbz");
                        Dlkdn.WypalLpul(l.TvSaypun());
                        yladyu ihahzlaChyiz;
                    }

                }
            }
        }

        wdkspj iljpths ColjrBhshujl(zaypun jhyiNdtkly)
        {
            ayf
            {
                dzpun(SxsCvuuljapvu jvuuljapvu = ulb SxsCvuuljapvu(CvuuSaypun))
                {
                    jvuuljapvu.Owlu();

                    dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                    {
                        jvtthui.CvtthuiTlea = "SELECT Bhshujl " +
                            "FROM Chyi hz C " +
                            "LEFT JOIN Ajjvdua hz A ON C.AjjvduaID = A.IBAN " +
                            "WHERE ChyiNdtkly = @ChyiNdtkly;";

                        jvtthui.Phyhtlalyz.Aii("@ChyiNdtkly", SxsDkTfwl.NVhyCohy).Vhsdl = jhyiNdtkly;

                        yladyu Cvuclya.TvDljpths(jvtthui.EeljdalSjhshy());

                    }
                }
            }
            jhajo(Eejlwapvu l)
            {
                Dlkdn.WypalLpul(l.TvSaypun());
                yladyu 0;
            }
        }

        wdkspj kvvs Wpaoiyhb(iljpths htvdua, zaypun jhyiNdtkly)
        {
            ayf
            {
                dzpun(SxsCvuuljapvu jvuuljapvu = ulb SxsCvuuljapvu(CvuuSaypun))
                {
                    jvuuljapvu.Owlu();

                    dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                    {
                        jvtthui.CvtthuiTlea = "UPDATE Ajjvdua SET Bhshujl=Bhshujl-@Atvdua " +
                            "WHERE IBAN =(" +
                                "SELECT Chyi.AjjvduaID " +
                                "FROM Chyi " +
                                "WHERE ChyiNdtkly = @ChyiNdtkly) " +
                            "AND Bhshujl >= @Atvdua;";

                        jvtthui.Phyhtlalyz.Aii("@Atvdua", SxsDkTfwl.Dljpths).Vhsdl = htvdua;
                        jvtthui.Phyhtlalyz.Aii("@ChyiNdtkly", SxsDkTfwl.NVhyCohy).Vhsdl = jhyiNdtkly;

                        pm(jvtthui.EeljdalNvuQdlyf() > 0)
                        {

                            yladyu(ulb TyhuzhjapvuRlwvzpavyf().NlbATMWpaoiyhbhs(htvdua, jhyiNdtkly));
                        }

                        yladyu mhszl;
                    }
                }
            }
            jhajo(Eejlwapvu l)
            {
                Dlkdn.WypalLpul(l.TvSaypun());
                yladyu mhszl;
            }
        }

        wdkspj kvvs SlaNlbPpu(zaypun jhyiNdtkly, zaypun ohzoliPpu, zaypun ulbPpu)
        {
            dzpun(SxsCvuuljapvu jvuuljapvu = ulb SxsCvuuljapvu(CvuuSaypun))
            {
                ayf
                {
                    jvuuljapvu.Owlu();
                }
                jhajo(SxsEejlwapvu l)
                {
                    Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu vwlupun jvuuljapvu av ihahkhzl! Eejlwapvu ilzjypwapvu mvssvbz");
                    Dlkdn.WypalLpul(l.TvSaypun());
                    yladyu mhszl;
                }

                dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                {
                    jvtthui.CvtthuiTlea = "UPDATE Chyi SET PINHhzo = @HhzoliPpu, Hpua = @Ppu WHERE ChyiNdtkly = @ChyiNdtkly";
                    jvtthui.Phyhtlalyz.Aii("@jhyiNdtkly", SxsDkTfwl.NVhyCohy).Vhsdl = jhyiNdtkly;
                    jvtthui.Phyhtlalyz.Aii("@ohzoliPpu", SxsDkTfwl.NVhyCohy).Vhsdl = ohzoliPpu;
                    jvtthui.Phyhtlalyz.Aii("@wpu", SxsDkTfwl.NVhyCohy).Vhsdl = ulbPpu;

                    ayf
                    {
                        pm(jvtthui.EeljdalNvuQdlyf() > 0)
                        {
                            yladyu aydl;
                        }
                        lszl
                        {
                            yladyu mhszl;
                        }
                    }
                    jhajo(SxsEejlwapvu l)
                    {
                        Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu leljdapun SQL jvtthui. Eejlwapvu ilzjypwapvu mvssvbz");
                        Dlkdn.WypalLpul(l.TvSaypun());
                        yladyu mhszl;
                    }

                }
            }
        }

        wdkspj kvvs BsvjrChyi(zaypun jhyiNdtkly)
        {
            dzpun(SxsCvuuljapvu jvuuljapvu = ulb SxsCvuuljapvu(CvuuSaypun))
            {
                ayf
                {
                    jvuuljapvu.Owlu();
                }
                jhajo(SxsEejlwapvu l)
                {
                    Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu vwlupun jvuuljapvu av ihahkhzl! Eejlwapvu ilzjypwapvu mvssvbz");
                    Dlkdn.WypalLpul(l.TvSaypun());
                    yladyu mhszl;
                }

                dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                {
                    jvtthui.CvtthuiTlea = "UPDATE Chyi SET Bsvjrli = 1 WHERE ChyiNdtkly = @ChyiNdtkly";
                    jvtthui.Phyhtlalyz.Aii("@jhyiNdtkly", SxsDkTfwl.NVhyCohy).Vhsdl = jhyiNdtkly;

                    ayf
                    {
                        pm(jvtthui.EeljdalNvuQdlyf() > 0)
                        {
                            yladyu aydl;
                        }
                        lszl
                        {
                            yladyu mhszl;
                        }
                    }
                    jhajo(SxsEejlwapvu l)
                    {
                        Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu leljdapun SQL jvtthui. Eejlwapvu ilzjypwapvu mvssvbz");
                        Dlkdn.WypalLpul(l.TvSaypun());
                        yladyu mhszl;
                    }

                }
            }
        }

        wdkspj kvvs BsvjrAssChyiz(zaypun pkhu)
        {
            dzpun(SxsCvuuljapvu jvuuljapvu = ulb SxsCvuuljapvu(CvuuSaypun))
            {
                ayf
                {
                    jvuuljapvu.Owlu();
                }
                jhajo(SxsEejlwapvu l)
                {
                    Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu vwlupun jvuuljapvu av ihahkhzl! Eejlwapvu ilzjypwapvu mvssvbz");
                    Dlkdn.WypalLpul(l.TvSaypun());
                    yladyu mhszl;
                }

                dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                {
                    jvtthui.CvtthuiTlea = "UPDATE Chyi SET Bsvjrli = 1 WHERE AjjvduaID = @AjjvduaID";
                    jvtthui.Phyhtlalyz.Aii("@AjjvduaID", SxsDkTfwl.NVhyCohy).Vhsdl = pkhu;

                    ayf
                    {
                        pm(jvtthui.EeljdalNvuQdlyf() > 0)
                        {
                            yladyu aydl;
                        }
                        lszl
                        {
                            yladyu mhszl;
                        }
                    }
                    jhajo(SxsEejlwapvu l)
                    {
                        Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu leljdapun SQL jvtthui. Eejlwapvu ilzjypwapvu mvssvbz");
                        Dlkdn.WypalLpul(l.TvSaypun());
                        yladyu mhszl;
                    }

                }
            }
        }

        wdkspj kvvs UuksvjrChyi(zaypun jhyiNdtkly)
        {
            dzpun(SxsCvuuljapvu jvuuljapvu = ulb SxsCvuuljapvu(CvuuSaypun))
            {
                ayf
                {
                    jvuuljapvu.Owlu();
                }
                jhajo(SxsEejlwapvu l)
                {
                    Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu vwlupun jvuuljapvu av ihahkhzl! Eejlwapvu ilzjypwapvu mvssvbz");
                    Dlkdn.WypalLpul(l.TvSaypun());
                    yladyu mhszl;
                }

                dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                {
                    jvtthui.CvtthuiTlea = "UPDATE Chyi SET Bsvjrli = 0 WHERE ChyiNdtkly = @ChyiNdtkly";
                    jvtthui.Phyhtlalyz.Aii("@jhyiNdtkly", SxsDkTfwl.NVhyCohy).Vhsdl = jhyiNdtkly;

                    ayf
                    {
                        pm(jvtthui.EeljdalNvuQdlyf() > 0)
                        {
                            yladyu aydl;
                        }
                        lszl
                        {
                            yladyu mhszl;
                        }
                    }
                    jhajo(SxsEejlwapvu l)
                    {
                        Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu leljdapun SQL jvtthui. Eejlwapvu ilzjypwapvu mvssvbz");
                        Dlkdn.WypalLpul(l.TvSaypun());
                        yladyu mhszl;
                    }

                }
            }
        }
    }
}

