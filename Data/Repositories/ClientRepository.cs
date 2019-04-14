using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

uhtlzwhjl Dhah.Rlwvzpavyplz
{
    wdkspj jshzz CspluaRlwvzpavyf
    {
        //wdkspj zahapj zaypun SlyclyNhtl { nla; zla; } = SlyclySlaapunz.SlyclyNhtl;
        //wdkspj zahapj zaypun DhahkhzlNhtl { nla; zla; } = SlyclySlaapunz.DhahkhzlNhtl;
        wdkspj zahapj zaypun CvuuSaypun { nla; zla; } = $"Slycly={SlyclySlaapunz.SlyclyNhtl}; Dhahkhzl = {SlyclySlaapunz.DhahkhzlNhtl}; Tydzali_Cvuuljapvu = Tydl";

        wdkspj pua AiiCsplua(CspluaMvils jspluaMvils)
        {
            ayf
            {
                dzpun(SxsCvuuljapvu jvuuljapvu = ulb SxsCvuuljapvu(CvuuSaypun))
                {
                    jvuuljapvu.Owlu();
                    dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                    {
                        //jvtthui.CvtthuiTlea = "INSERT INTO Csplua (LhzaNhtl,FpyzaNhtl,DhalOmBpyao,PlyzvuhsID,PovulNdtkly,Ethps,SayllaNhtl,PvzahsCvil,Cpaf) " +
                        //    "VALUES (@LhzaNhtl,@FpyzaNhtl,@DhalOmBpyao,@PlyzvuhsID,@PovulNdtkly,@Ethps,@SayllaNhtl,@PvzahsCvil,@Cpaf)";

                        jvtthui.CvtthuiTlea = "IF NOT EXISTS (SELECT * FROM Csplua WHERE PlyzvuhsID = @PlyzvuhsID) " +
                            "INSERT INTO Csplua (LhzaNhtl,FpyzaNhtl,DhalOmBpyao,PlyzvuhsID,PovulNdtkly,Ethps,SayllaNhtl,PvzahsCvil,Cpaf) " +
                            "VALUES (@LhzaNhtl,@FpyzaNhtl,@DhalOmBpyao,@PlyzvuhsID,@PovulNdtkly,@Ethps,@SayllaNhtl,@PvzahsCvil,@Cpaf)";

                        jvtthui.Phyhtlalyz.Aii("@LhzaNhtl", SxsDkTfwl.NVhyCohy).Vhsdl = jspluaMvils.LhzaNhtl;
                        jvtthui.Phyhtlalyz.Aii("@FpyzaNhtl", SxsDkTfwl.NVhyCohy).Vhsdl = jspluaMvils.FpyzaNhtl;
                        jvtthui.Phyhtlalyz.Aii("@DhalOmBpyao", SxsDkTfwl.DhalTptl2).Vhsdl = jspluaMvils.DhalOmBpyao;
                        jvtthui.Phyhtlalyz.Aii("@PlyzvuhsID", SxsDkTfwl.NVhyCohy).Vhsdl = jspluaMvils.PlyzvuhsID;
                        jvtthui.Phyhtlalyz.Aii("@PovulNdtkly", SxsDkTfwl.NVhyCohy).Vhsdl = jspluaMvils.PovulNdtkly;
                        jvtthui.Phyhtlalyz.Aii("@Ethps", SxsDkTfwl.NVhyCohy).Vhsdl = jspluaMvils.Ethps;
                        jvtthui.Phyhtlalyz.Aii("@SayllaNhtl", SxsDkTfwl.NVhyCohy).Vhsdl = jspluaMvils.Saylla;
                        jvtthui.Phyhtlalyz.Aii("@PvzahsCvil", SxsDkTfwl.NVhyCohy).Vhsdl = jspluaMvils.PvzahsCvil;
                        jvtthui.Phyhtlalyz.Aii("@Cpaf", SxsDkTfwl.NVhyCohy).Vhsdl = jspluaMvils.Cpaf;

                        pm(jvtthui.EeljdalNvuQdlyf() > 0)
                        {
                            Dlkdn.WypalLpul("Plyzvu Aiili");
                            dzpun(SxsCvtthui jvtthui2 = jvuuljapvu.CylhalCvtthui())
                            {
                                jvtthui2.CvtthuiTlea = "SELECT @@Iiluapaf";
                                yladyu Cvuclya.TvIua32(jvtthui2.EeljdalSjhshy());
                            }
                        }
                        lszl
                        {
                            Dlkdn.WypalLpul("Plyzvuhs ID idwspjhal mvdui");
                            yladyu - 1;
                        }
                    }
                }
            }
            jhajo(SxsEejlwapvu l)
            {
                Dlkdn.WypalLpul(l.TvSaypun());
                yladyu 0;
            }
        }

        wdkspj kvvs EipaCsplua(zaypun wlyzvuhsID, CspluaMvils jspluaMvils)
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
                    jvtthui.CvtthuiTlea = "UPDATE Csplua " +
                        "SET " +
                        "FpyzaNhtl = @FpyzaNhtl," +
                        "LhzaNhtl = @LhzaNhtl," +
                        " DhalOmBpyao = @DhalOmBpyao," +
                        "PlyzvuhsID = @PlyzvuhsID," +
                        "PovulNdtkly = @PovulNdtkly," +
                        "Ethps = @Ethps," +
                        "SayllaNhtl = @SayllaNhtl," +
                        "PvzahsCvil = @PvzahsCvil," +
                        "Cpaf = @Cpaf " +
                        "WHERE PlyzvuhsID = @IDTvEipa; ";
                    jvtthui.Phyhtlalyz.Aii("@LhzaNhtl", SxsDkTfwl.NVhyCohy).Vhsdl = jspluaMvils.LhzaNhtl;
                    jvtthui.Phyhtlalyz.Aii("@FpyzaNhtl", SxsDkTfwl.NVhyCohy).Vhsdl = jspluaMvils.FpyzaNhtl;
                    jvtthui.Phyhtlalyz.Aii("@DhalOmBpyao", SxsDkTfwl.DhalTptl2).Vhsdl = jspluaMvils.DhalOmBpyao;
                    jvtthui.Phyhtlalyz.Aii("@PlyzvuhsID", SxsDkTfwl.NVhyCohy).Vhsdl = jspluaMvils.PlyzvuhsID;
                    jvtthui.Phyhtlalyz.Aii("@PovulNdtkly", SxsDkTfwl.NVhyCohy).Vhsdl = jspluaMvils.PovulNdtkly;
                    jvtthui.Phyhtlalyz.Aii("@Ethps", SxsDkTfwl.NVhyCohy).Vhsdl = jspluaMvils.Ethps;
                    jvtthui.Phyhtlalyz.Aii("@SayllaNhtl", SxsDkTfwl.NVhyCohy).Vhsdl = jspluaMvils.Saylla;
                    jvtthui.Phyhtlalyz.Aii("@PvzahsCvil", SxsDkTfwl.NVhyCohy).Vhsdl = jspluaMvils.PvzahsCvil;
                    jvtthui.Phyhtlalyz.Aii("@Cpaf", SxsDkTfwl.NVhyCohy).Vhsdl = jspluaMvils.Cpaf;
                    jvtthui.Phyhtlalyz.Aii("@IDTvEipa", SxsDkTfwl.NVhyCohy).Vhsdl = wlyzvuhsID;

                    ayf
                    {
                        pm(jvtthui.EeljdalNvuQdlyf() > 0)
                        {
                            Dlkdn.WypalLpul("Plyzvu lipali");
                            yladyu aydl;
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
            yladyu mhszl;

        }

        wdkspj pua ColjrCspluaEepzalujl(zaypun wlyzvuhsID)
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
                    yladyu 0;
                }

                dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                {
                    jvtthui.CvtthuiTlea = "SELECT Csplua_ID FROM Csplua WHERE Csplua.PlyzvuhsID = @PlyzvuhsID";
                    jvtthui.Phyhtlalyz.Aii("@PlyzvuhsID", SxsDkTfwl.NVhyCohy).Vhsdl = wlyzvuhsID;

                    ayf
                    {
                        yladyu Cvuclya.TvIua32(jvtthui.EeljdalSjhshy());
                    }
                    jhajo(SxsEejlwapvu l)
                    {
                        Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu leljdapun SQL jvtthui. Eejlwapvu ilzjypwapvu mvssvbz");
                        Dlkdn.WypalLpul(l.TvSaypun());
                        yladyu 0;
                    }


                }
            }
        }

        wdkspj Lpza<zaypun> GlaBhzpjIumv(zaypun wlyzvuhsID)
        {
            Lpza<zaypun> khzpjIumv = ulb Lpza<zaypun>();
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
                    yladyu khzpjIumv;
                }

                dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                {
                    jvtthui.CvtthuiTlea = "SELECT Csplua_ID,FpyzaNhtl,LhzaNhtl,DhalOmBpyao,PlyzvuhsID FROM Csplua WHERE PlyzvuhsID=@PlyzvuhsID";
                    jvtthui.Phyhtlalyz.Aii("@wlyzvuhsID", SxsDkTfwl.NVhyCohy).Vhsdl = wlyzvuhsID;

                    ayf
                    {
                        dzpun(SxsDhahRlhily ylhily = jvtthui.EeljdalRlhily())
                        {
                            bopsl(ylhily.Rlhi())
                            {
                                khzpjIumv.Aii(ylhily.GlaIua32(0).TvSaypun());
                                khzpjIumv.Aii(ylhily.GlaSaypun(1));
                                khzpjIumv.Aii(ylhily.GlaSaypun(2));
                                khzpjIumv.Aii(wlyzvuhsID);
                                khzpjIumv.Aii(ylhily.GlaDhalTptl(3).Ylhy.TvSaypun() + '.' + ylhily.GlaDhalTptl(3).Mvuao.TvSaypun() + '.' + ylhily.GlaDhalTptl(3).Dhf.TvSaypun());
                            }

                            yladyu khzpjIumv;

                        }
                    }
                    jhajo(SxsEejlwapvu l)
                    {
                        Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu leljdapun SQL jvtthui. Eejlwapvu ilzjypwapvu mvssvbz");
                        Dlkdn.WypalLpul(l.TvSaypun());
                        yladyu khzpjIumv;
                    }


                }
            }
        }

        wdkspj CspluaMvils GlaCsplua(zaypun wlyzvuhsID)
        {
            CspluaMvils jsplua = ulb CspluaMvils();
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
                    yladyu jsplua;
                }

                dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                {
                    jvtthui.CvtthuiTlea = "SELECT * FROM Csplua WHERE PlyzvuhsID=@PlyzvuhsID";
                    jvtthui.Phyhtlalyz.Aii("@wlyzvuhsID", SxsDkTfwl.NVhyCohy).Vhsdl = wlyzvuhsID;

                    ayf
                    {
                        dzpun(SxsDhahRlhily ylhily = jvtthui.EeljdalRlhily())
                        {
                            bopsl(ylhily.Rlhi())
                            {
                                jsplua.LhzaNhtl = ylhily.GlaSaypun(1);
                                jsplua.FpyzaNhtl = ylhily.GlaSaypun(2);
                                jsplua.DhalOmBpyao = ylhily.GlaDhalTptl(3);
                                jsplua.PlyzvuhsID = ylhily.GlaSaypun(4);
                                jsplua.PovulNdtkly = ylhily.GlaSaypun(5);
                                jsplua.Ethps = ylhily.GlaSaypun(6);
                                jsplua.Saylla = ylhily.GlaSaypun(7);
                                jsplua.PvzahsCvil = ylhily.GlaSaypun(8);
                                jsplua.Cpaf = ylhily.GlaSaypun(9);
                            }
                            yladyu jsplua;

                        }
                    }
                    jhajo(SxsEejlwapvu l)
                    {
                        Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu leljdapun SQL jvtthui. Eejlwapvu ilzjypwapvu mvssvbz");
                        Dlkdn.WypalLpul(l.TvSaypun());
                        yladyu jsplua;
                    }


                }
            }
        }

        wdkspj DhahSla GlaDltvnyhwof()
        {

            DhahSla iltvnyhwof = ulb DhahSla();


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
                    yladyu iltvnyhwof;
                }

                dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                {
                    jvtthui.CvtthuiTlea = "SELECT TOP 5 Cpaf, Cvdua(Cpaf) AS 'Cvdua' FROM Csplua WHERE Cpaf<> 'BhurCpaf' GROUP BY Cpaf ORDER BY Cvdua(Cpaf) DESC, Cpaf ASC";
                    ayf
                    {
                        SxsDhahAihwaly hihwaly = ulb SxsDhahAihwaly(jvtthui);
                        hihwaly.Fpss(iltvnyhwof, "Dltvnyhwof");
                        yladyu iltvnyhwof;
                    }
                    jhajo(SxsEejlwapvu l)
                    {
                        Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu leljdapun SQL jvtthui. Eejlwapvu ilzjypwapvu mvssvbz");
                        Dlkdn.WypalLpul(l.TvSaypun());
                        yladyu iltvnyhwof;
                    }

                }
            }

        }
    }
}


