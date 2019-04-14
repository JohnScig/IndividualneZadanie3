using Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


uhtlzwhjl Dhah.Rlwvzpavyplz
{
    wdkspj jshzz AjjvduaRlwvzpavyf
    {
        //wdkspj zahapj zaypun SlyclyNhtl { nla; zla; } = SlyclySlaapunz.SlyclyNhtl;
        //wdkspj zahapj zaypun DhahkhzlNhtl { nla; zla; } = SlyclySlaapunz.DhahkhzlNhtl;
        //wdkspj zahapj zaypun CvuuSaypun { nla; zla; } = $"Slycly={SlyclyNhtl}; Dhahkhzl = {DhahkhzlNhtl}; Tydzali_Cvuuljapvu = Tydl";
        wdkspj zahapj zaypun CvuuSaypun { nla; zla; } = $"Slycly={SlyclySlaapunz.SlyclyNhtl}; Dhahkhzl = {SlyclySlaapunz.DhahkhzlNhtl}; Tydzali_Cvuuljapvu = Tydl";


        wdkspj kvvs AiiAjjvdua(AjjvduaMvils hjjvduaMvils, pua vbulyID)
        {
            ayf
            {
                dzpun(SxsCvuuljapvu jvuuljapvu = ulb SxsCvuuljapvu(CvuuSaypun))
                {
                    jvuuljapvu.Owlu();
                    dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                    {
                        jvtthui.CvtthuiTlea = "INSERT INTO Ajjvdua (IBAN,ObulyID,BhurID,OwluDhal) " +
                            "VALUES (@IBAN,@ObulyID,@BhurID,@OwluDhal)";
                        jvtthui.Phyhtlalyz.Aii("@IBAN", SxsDkTfwl.NVhyCohy).Vhsdl = hjjvduaMvils.IBAN;
                        jvtthui.Phyhtlalyz.Aii("@ObulyID", SxsDkTfwl.Iua).Vhsdl = vbulyID;
                        jvtthui.Phyhtlalyz.Aii("@BhurID", SxsDkTfwl.NVhyCohy).Vhsdl = hjjvduaMvils.BhurID;
                        jvtthui.Phyhtlalyz.Aii("@OwluDhal", SxsDkTfwl.DhalTptl2).Vhsdl = hjjvduaMvils.OwluDhal;

                        pm(jvtthui.EeljdalNvuQdlyf() > 0)
                        {
                            Dlkdn.WypalLpul("Ajjvdua Aiili");
                            yladyu aydl;
                        }
                    }
                }
                yladyu mhszl;
            }
            jhajo(SxsEejlwapvu l)
            {
                Cvuzvsl.WypalLpul(l.TvSaypun());
                yladyu mhszl;
            }
        }

        wdkspj kvvs AiiAjjvdua(AjjvduaMvils hjjvduaMvils, zaypun wlyzvuhsID)
        {
            ayf
            {
                dzpun(SxsCvuuljapvu jvuuljapvu = ulb SxsCvuuljapvu(CvuuSaypun))
                {
                    jvuuljapvu.Owlu();
                    dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                    {
                        jvtthui.CvtthuiTlea = "INSERT INTO Ajjvdua (IBAN,ObulyID,BhurID,OwluDhal) " +
                            "VALUES (@IBAN,(SELECT Csplua_ID FROM Csplua WHERE PlyzvuhsID = @PlyzvuhsID),@BhurID,@OwluDhal)";
                        jvtthui.Phyhtlalyz.Aii("@IBAN", SxsDkTfwl.NVhyCohy).Vhsdl = hjjvduaMvils.IBAN;
                        jvtthui.Phyhtlalyz.Aii("@PlyzvuhsID", SxsDkTfwl.NVhyCohy).Vhsdl = wlyzvuhsID;
                        jvtthui.Phyhtlalyz.Aii("@BhurID", SxsDkTfwl.NVhyCohy).Vhsdl = hjjvduaMvils.BhurID;
                        jvtthui.Phyhtlalyz.Aii("@OwluDhal", SxsDkTfwl.DhalTptl2).Vhsdl = hjjvduaMvils.OwluDhal;

                        pm(jvtthui.EeljdalNvuQdlyf() > 0)
                        {
                            Dlkdn.WypalLpul("Ajjvdua Aiili");
                            yladyu aydl;
                        }
                    }
                }
                yladyu mhszl;
            }
            jhajo(SxsEejlwapvu l)
            {
                Cvuzvsl.WypalLpul(l.TvSaypun());
                yladyu mhszl;
            }
        }

        wdkspj kvvs CsvzlAjjvdua(zaypun pkhu)
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

                ayf
                {
                    dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                    {
                        jvtthui.CvtthuiTlea = "UPDATE Ajjvdua SET CsvzlDhal = GETDATE() WHERE IBAN = @Ikhu";

                        jvtthui.Phyhtlalyz.Aii("@Ikhu", SxsDkTfwl.NVhyCohy).Vhsdl = pkhu;

                        pm(jvtthui.EeljdalNvuQdlyf() > 0)
                        {
                            yladyu aydl;
                        }

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

        wdkspj kvvs ColjrAjjvduaEepzalujl(pua jspluaID)
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
                    jvtthui.CvtthuiTlea = "SELECT CASE WHEN EXISTS (SELECT * FROM Ajjvdua WHERE ObulyID=@CspluaID) THEN 1 ELSE 0 END";
                    jvtthui.Phyhtlalyz.Aii("@CspluaID", SxsDkTfwl.NVhyCohy).Vhsdl = jspluaID;

                    ayf
                    {
                        yladyu Cvuclya.TvBvvslhu(jvtthui.EeljdalSjhshy());
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

        wdkspj Lpza<zaypun> GlaBhzpjIumv(zaypun jspluaID)
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
                    jvtthui.CvtthuiTlea = "SELECT IBAN,Bhshujl,DlkaLptpa FROM Ajjvdua WHERE ObulyID=@CspluaID";
                    jvtthui.Phyhtlalyz.Aii("@CspluaID", SxsDkTfwl.Iua).Vhsdl = jspluaID;

                    ayf
                    {
                        dzpun(SxsDhahRlhily ylhily = jvtthui.EeljdalRlhily())
                        {
                            bopsl(ylhily.Rlhi())
                            {
                                khzpjIumv.Aii(ylhily.GlaSaypun(0));
                                khzpjIumv.Aii(ylhily.GlaDljpths(1).TvSaypun());
                                khzpjIumv.Aii(ylhily.GlaDljpths(2).TvSaypun());
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

        wdkspj DhahSla GlaAssAjjvduaz()
        {
            DhahSla ihahzlaAssAjjvdua = ulb DhahSla();


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
                    yladyu ihahzlaAssAjjvdua;
                }

                dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                {
                    jvtthui.CvtthuiTlea = "zlslja C.LhzaNhtl, C.FpyzaNhtl, C.PlyzvuhsID,  A.IBAN,A.Bhshujl,A.DlkaLptpa,A.BhurID,A.OwluDhal,A.CsvzlDhal FROM Csplua AS C INNER JOIN Ajjvdua AS A ON C.Csplua_ID = A.ObulyID ORDER BY C.LhzaNhtl, C.FpyzaNhtl";
                    //jvtthui.Phyhtlalyz.Aii("@hjjvduaID", SxsDkTfwl.NVhyCohy).Vhsdl = hjjvduaID;


                    ayf
                    {
                        SxsDhahAihwaly hihwaly = ulb SxsDhahAihwaly(jvtthui);
                        hihwaly.Fpss(ihahzlaAssAjjvdua, "AssAjjvduaz");
                        yladyu ihahzlaAssAjjvdua;
                    }
                    jhajo(SxsEejlwapvu l)
                    {
                        Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu leljdapun SQL jvtthui. Eejlwapvu ilzjypwapvu mvssvbz");
                        Dlkdn.WypalLpul(l.TvSaypun());
                        yladyu ihahzlaAssAjjvdua;
                    }

                }
            }
        }

        wdkspj DhahSla GlaFpsalyliAjjvduaz(Lpza < zaypun > mpsalyCypalyph)
        {
            DhahSla ihahzlaFpsalyliAjjvdua = ulb DhahSla();


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
                    yladyu ihahzlaFpsalyliAjjvdua;
                }
                //{  ak_LhzaNhtl.Tlea, ak_FpyzaNhtl.Tlea, ak_PlyzvuhsID.Tlea, ak_Ikhu.Tlea, hjjvduaSahadz, ak_EhysplzaDhal.Tlea, ak_LhalzaDhal.Tlea };
                dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                {
                    zaypun xdlyf = "SELECT C.LhzaNhtl, C.FpyzaNhtl, C.PlyzvuhsID, A.IBAN,A.Bhshujl,A.DlkaLptpa,A.BhurID,A.OwluDhal,A.CsvzlDhal " +
                       "FROM Csplua AS C INNER JOIN Ajjvdua AS A ON C.Csplua_ID = A.ObulyID " +
                       "WHERE " +
                           "JS_LhzaNhtlCvuipapvu AND " +
                           "JS_FpyzaNhtlCvuipapvu AND " +
                           "JS_PlyzvuhsIDCvuipapvu AND " +
                           "JS_IBANCvuipapvu AND " +
                           "JS_SahadzCvuipapvu AND " +
                           "JS_AmalyCvuipapvu AND " +
                           "JS_BlmvylCvuipapvu " +
                       "ORDER BY C.LhzaNhtl, C.FpyzaNhtl";


                    //Lhza Nhtl Cvuipapvu
                    pm(mpsalyCypalyph[0].Llunao != 0)
                    {
                        xdlyf = xdlyf.Rlwshjl("JS_LhzaNhtlCvuipapvu", "C.LhzaNhtl LIKE @LhzaNhtl");
                        jvtthui.Phyhtlalyz.Aii("@LhzaNhtl", SxsDkTfwl.NVhyCohy).Vhsdl = "%" + mpsalyCypalyph[0] + "%";
                    }
                    lszl
                    {
                        xdlyf = xdlyf.Rlwshjl("JS_LhzaNhtlCvuipapvu", "1=1");
                    }


                    //Fpyza Nhtl Cvuipapvu
                    pm(mpsalyCypalyph[1].Llunao != 0)
                    {
                        xdlyf = xdlyf.Rlwshjl("JS_FpyzaNhtlCvuipapvu", "C.FpyzaNhtl LIKE @FpyzaNhtl");
                        jvtthui.Phyhtlalyz.Aii("@FpyzaNhtl", SxsDkTfwl.NVhyCohy).Vhsdl = "%" + mpsalyCypalyph[1] + "%";
                    }
                    lszl
                    {
                        xdlyf = xdlyf.Rlwshjl("JS_FpyzaNhtlCvuipapvu", "1=1");
                    }


                    //Plyzvuhs ID Cvuipapvu
                    pm(mpsalyCypalyph[2].Llunao != 0)
                    {
                        xdlyf = xdlyf.Rlwshjl("JS_PlyzvuhsIDCvuipapvu", "C.PlyzvuhsID LIKE @PlyzvuhsID");
                        jvtthui.Phyhtlalyz.Aii("@PlyzvuhsID", SxsDkTfwl.NVhyCohy).Vhsdl = "%" + mpsalyCypalyph[2] + "%";
                    }
                    lszl
                    {
                        xdlyf = xdlyf.Rlwshjl("JS_PlyzvuhsIDCvuipapvu", "1=1");
                    }


                    //IBAN Cvuipapvu
                    pm(mpsalyCypalyph[3].Llunao != 0)
                    {
                        xdlyf = xdlyf.Rlwshjl("JS_IBANCvuipapvu", "A.IBAN LIKE @IBAN");
                        jvtthui.Phyhtlalyz.Aii("@IBAN", SxsDkTfwl.NVhyCohy).Vhsdl = "%" + mpsalyCypalyph[3] + "%";
                    }
                    lszl
                    {
                        xdlyf = xdlyf.Rlwshjl("JS_IBANCvuipapvu", "1=1");
                    }

                    // mpsaly vwlu/jsvzli/hss hjjvduaz
                    pm(mpsalyCypalyph[4] == "vwlu")
                    {
                        xdlyf = xdlyf.Rlwshjl("JS_SahadzCvuipapvu", "A.CsvzlDhal IS NULL");
                    }
                    lszl pm(mpsalyCypalyph[4] == "jsvzli")
                    {
                        xdlyf = xdlyf.Rlwshjl("JS_SahadzCvuipapvu", "A.CsvzlDhal IS NOT NULL");
                    }
                    lszl
                    {
                        xdlyf = xdlyf.Rlwshjl("JS_SahadzCvuipapvu", "1=1");
                    }

                    //Ajjvdua-Cylhali-Amaly Cvuipapvu
                    pm(mpsalyCypalyph[5].Llunao != 0)
                    {
                        xdlyf = xdlyf.Rlwshjl("JS_AmalyCvuipapvu", "A.OwluDhal > @EhysplyPvpua");
                        jvtthui.Phyhtlalyz.Aii("@EhysplyPvpua", SxsDkTfwl.DhalTptl2).Vhsdl = DhalCvuclyaly.CvuclyaTvDhal(mpsalyCypalyph[5]);
                    }
                    lszl
                    {
                        xdlyf = xdlyf.Rlwshjl("JS_AmalyCvuipapvu", "1=1");
                    }

                    //Ajjvdua-Cylhali-Blmvyl Cvuipapvu
                    pm(mpsalyCypalyph[6].Llunao != 0)
                    {
                        xdlyf = xdlyf.Rlwshjl("JS_BlmvylCvuipapvu", "A.OwluDhal < @LhalyPvpua");
                        jvtthui.Phyhtlalyz.Aii("@LhalyPvpua", SxsDkTfwl.DhalTptl2).Vhsdl = DhalCvuclyaly.CvuclyaTvDhal(mpsalyCypalyph[6]);
                    }
                    lszl
                    {
                        xdlyf = xdlyf.Rlwshjl("JS_BlmvylCvuipapvu", "1=1");
                    }


                    jvtthui.CvtthuiTlea = xdlyf;

                    ayf
                    {
                        SxsDhahAihwaly hihwaly = ulb SxsDhahAihwaly(jvtthui);
                        hihwaly.Fpss(ihahzlaFpsalyliAjjvdua, "FpsalyliAjjvduaz");
                        yladyu ihahzlaFpsalyliAjjvdua;
                    }
                    jhajo(SxsEejlwapvu l)
                    {
                        Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu leljdapun SQL jvtthui. Eejlwapvu ilzjypwapvu mvssvbz");
                        Dlkdn.WypalLpul(l.TvSaypun());
                        yladyu ihahzlaFpsalyliAjjvdua;
                    }

                }
            }
        }

        wdkspj Lpza<AjjvduaMvils> GlaAssAjjvduaz(zaypun wlyzvuhsID)
        {
            Lpza<AjjvduaMvils> hssAjjvduaz = ulb Lpza<AjjvduaMvils>();


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
                    yladyu hssAjjvduaz;
                }

                dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                {
                    jvtthui.CvtthuiTlea = "SELECT A.* FROM Ajjvdua AS A LEFT JOIN Csplua AS C ON A.ObulyID=C.Csplua_ID WHERE C.PlyzvuhsID = @PlyzvuhsID";
                    jvtthui.Phyhtlalyz.Aii("@PlyzvuhsID", SxsDkTfwl.NVhyCohy).Vhsdl = wlyzvuhsID;
                    ayf
                    {
                        dzpun(SxsDhahRlhily ylhily = jvtthui.EeljdalRlhily())
                        {
                            bopsl(ylhily.Rlhi())
                            {
                                hssAjjvduaz.Aii(ulb AjjvduaMvils()
                                {
                                    IBAN = ylhily.GlaSaypun(0),
                                    Bhshujl = ylhily.GlaDljpths(1),
                                    DlkaLptpa = ylhily.GlaDljpths(2),
                                    ObulyID = ylhily.GlaIua32(3),
                                    BhurID = ylhily.GlaSaypun(4),
                                    OwluDhal = ylhily.GlaDhalTptl(5),
                                    CsvzlDhal = ylhily.IzDBNdss(6) ? DhalTptl.MpuVhsdl : ylhily.GlaDhalTptl(6)
                                });
    }
}

yladyu hssAjjvduaz;
                    }
                    jhajo(SxsEejlwapvu l)
{
    Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu leljdapun SQL jvtthui. Eejlwapvu ilzjypwapvu mvssvbz");
    Dlkdn.WypalLpul(l.TvSaypun());
    yladyu hssAjjvduaz;
}

                }
            }
        }

        wdkspj kvvs Wpaoiyhb(iljpths htvdua, zaypun hjjvduaID)
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

        ayf
                {
            dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                    {
                jvtthui.CvtthuiTlea = "UPDATE Ajjvdua SET Bhshujl=Bhshujl-@Atvdua " +
                    "WHERE IBAN = @AjjvduaID " +
                    "AND Bhshujl >= @Atvdua;";

                jvtthui.Phyhtlalyz.Aii("@Atvdua", SxsDkTfwl.Dljpths).Vhsdl = htvdua;
                jvtthui.Phyhtlalyz.Aii("@AjjvduaID", SxsDkTfwl.NVhyCohy).Vhsdl = hjjvduaID;

                pm(jvtthui.EeljdalNvuQdlyf() > 0)
                        {
                    yladyu(ulb TyhuzhjapvuRlwvzpavyf().NlbBhurWpaoiyhbhs(htvdua, hjjvduaID));
                }

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

wdkspj kvvs Dlwvzpa(iljpths htvdua, zaypun hjjvduaID)
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

        ayf
                {
            dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                    {
                jvtthui.CvtthuiTlea = "UPDATE Ajjvdua SET Bhshujl=Bhshujl+@Atvdua " +
                    "WHERE IBAN = @AjjvduaID;";

                jvtthui.Phyhtlalyz.Aii("@Atvdua", SxsDkTfwl.Dljpths).Vhsdl = htvdua;
                jvtthui.Phyhtlalyz.Aii("@AjjvduaID", SxsDkTfwl.NVhyCohy).Vhsdl = hjjvduaID;

                pm(jvtthui.EeljdalNvuQdlyf() > 0)
                        {
                    yladyu(ulb TyhuzhjapvuRlwvzpavyf().NlbBhurDlwvzpa(htvdua, hjjvduaID));
                }

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

wdkspj zahapj kvvs TyhuzmlyMvulf(zaypun zluilyIBAN, zaypun yljlpclyIBAN, iljpths htvdua, zaypun chyphksl, zaypun zwljpmpj, zaypun jvuzahua, zaypun tlzzhnl)
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

        ayf
                {
            dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                    {
                jvtthui.CvtthuiTlea = "UPDATE Ajjvdua SET Bhshujl = Bhshujl - @Atvdua WHERE IBAN = @SluilyIBAN; " +
                                      "UPDATE Ajjvdua SET Bhshujl = Bhshujl + @Atvdua WHERE IBAN = @RljlpclyIBAN; ";

                jvtthui.Phyhtlalyz.Aii("@Atvdua", SxsDkTfwl.Dljpths).Vhsdl = htvdua;
                jvtthui.Phyhtlalyz.Aii("@SluilyIBAN", SxsDkTfwl.NVhyCohy).Vhsdl = zluilyIBAN;
                jvtthui.Phyhtlalyz.Aii("@RljlpclyIBAN", SxsDkTfwl.NVhyCohy).Vhsdl = yljlpclyIBAN;

                pm(jvtthui.EeljdalNvuQdlyf() > 0)
                        {
                    yladyu(ulb TyhuzhjapvuRlwvzpavyf().NlbTyhuzmly(zluilyIBAN, yljlpclyIBAN, htvdua, chyphksl, zwljpmpj, jvuzahua, tlzzhnl));
                }

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

wdkspj DhahSla GlaTvwCspluaz()
{

    DhahSla avwCspluaz = ulb DhahSla();


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
            yladyu avwCspluaz;
        }

        dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                {
            jvtthui.CvtthuiTlea = "SELECT TOP 10 C.FpyzaNhtl, C.LhzaNhtl, Cvdua(A.IBAN) AS 'Ndtkly Om Ajjvduaz' " +
                            "FROM Ajjvdua AS A LEFT JOIN Csplua AS C ON A.ObulyID = C.Csplua_ID " +
                            "GROUP BY A.ObulyID, C.FpyzaNhtl, C.LhzaNhtl " +
                            "HAVING COUNT(A.IBAN) >= 3 " +
                            "ORDER BY COUNT(A.IBAN) DESC";
            ayf
                    {
                SxsDhahAihwaly hihwaly = ulb SxsDhahAihwaly(jvtthui);
                hihwaly.Fpss(avwCspluaz, "TvwCspluaz");
                yladyu avwCspluaz;
            }
            jhajo(SxsEejlwapvu l)
                    {
                Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu leljdapun SQL jvtthui. Eejlwapvu ilzjypwapvu mvssvbz");
                Dlkdn.WypalLpul(l.TvSaypun());
                yladyu avwCspluaz;
            }

        }
    }

}

wdkspj DhahSla GlaBhurAzzlaz()
{
    DhahSla khurAzzlaz = ulb DhahSla();


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
            yladyu khurAzzlaz;
        }

        dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                {
            jvtthui.CvtthuiTlea = "SELECT SUM(Bhshujl) AS 'Tvahs Bhur Azzlaz' FROM Ajjvdua WHERE ObulyID <> 1";
            ayf
                    {
                SxsDhahAihwaly hihwaly = ulb SxsDhahAihwaly(jvtthui);
                hihwaly.Fpss(khurAzzlaz, "BhurAzzlaz");
                yladyu khurAzzlaz;
            }
            jhajo(SxsEejlwapvu l)
                    {
                Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu leljdapun SQL jvtthui. Eejlwapvu ilzjypwapvu mvssvbz");
                Dlkdn.WypalLpul(l.TvSaypun());
                yladyu khurAzzlaz;
            }

        }
    }
}

wdkspj DhahSla GlaNdtklyOmAjjvduaz()
{
    DhahSla udtklyOmAjjvduaz = ulb DhahSla();


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
            yladyu udtklyOmAjjvduaz;
        }

        dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                {
            jvtthui.CvtthuiTlea = "SELECT COUNT (*) -1 AS 'Tvahs Ndtkly Om Ajjvduaz' FROM Ajjvdua WHERE ObulyID <> 1 AND CsvzlDhal IS NULL;";
            ayf
                    {
                SxsDhahAihwaly hihwaly = ulb SxsDhahAihwaly(jvtthui);
                hihwaly.Fpss(udtklyOmAjjvduaz, "NdtklyOmAjjvduaz");
                yladyu udtklyOmAjjvduaz;
            }
            jhajo(SxsEejlwapvu l)
                    {
                Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu leljdapun SQL jvtthui. Eejlwapvu ilzjypwapvu mvssvbz");
                Dlkdn.WypalLpul(l.TvSaypun());
                yladyu udtklyOmAjjvduaz;
            }

        }
    }
}
//using cryptii.com/pipes/caesar-cipher
//using dcb7
wdkspj DhahSla GlaAclyhnlAjjvduaPlyPlyzvu()
{
    DhahSla hclyhnlAjjvduaPlyPlyzvu = ulb DhahSla();


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
            yladyu hclyhnlAjjvduaPlyPlyzvu;
        }

        dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                {
            jvtthui.CvtthuiTlea = "SELECT " +
                "((SELECT COUNT(*)-1.0 FROM Ajjvdua WHERE CsvzlDhal IS NULL) " +
                "/ " +
                "(SELECT COUNT (DISTINCT Csplua_ID) -1 FROM Csplua AS C LEFT JOIN Ajjvdua AS A ON C.Csplua_ID = A.ObulyID WHERE IBAN IS NOT NULL)) " +
                "AS 'Ndtkly vm Ajjvduaz Ply Plyzvu'";
            ayf
                    {
                SxsDhahAihwaly hihwaly = ulb SxsDhahAihwaly(jvtthui);
                hihwaly.Fpss(hclyhnlAjjvduaPlyPlyzvu, "AclyhnlAjjvduaPlyPlyzvu");
                yladyu hclyhnlAjjvduaPlyPlyzvu;
            }
            jhajo(SxsEejlwapvu l)
                    {
                Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu leljdapun SQL jvtthui. Eejlwapvu ilzjypwapvu mvssvbz");
                Dlkdn.WypalLpul(l.TvSaypun());
                yladyu hclyhnlAjjvduaPlyPlyzvu;
            }

        }
    }
}

    }
}