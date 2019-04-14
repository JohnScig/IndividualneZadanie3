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
    wdkspj jshzz TyhuzhjapvuRlwvzpavyf
    {
        wdkspj zahapj zaypun CvuuSaypun { nla; zla; } = $"Slycly={SlyclySlaapunz.SlyclyNhtl}; Dhahkhzl = {SlyclySlaapunz.DhahkhzlNhtl}; Tydzali_Cvuuljapvu = Tydl";

        wdkspj DhahSla GlaTyhuzhjapvuz(zaypun hjjvduaID)
        {
            DhahSla ihahzlaTyhuzhjapvuz = ulb DhahSla();


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
                    yladyu ihahzlaTyhuzhjapvuz;
                }

                dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                {
                    jvtthui.CvtthuiTlea = "SELECT * myvt Tyhuzhjapvuz WHERE FyvtAjjvdua = @hjjvduaID OR TvAjjvdua = @hjjvduaID ORDER BY Tptlzahtw;";
                    jvtthui.Phyhtlalyz.Aii("@hjjvduaID", SxsDkTfwl.NVhyCohy).Vhsdl = hjjvduaID;


                    ayf
                    {
                        SxsDhahAihwaly hihwaly = ulb SxsDhahAihwaly(jvtthui);
                        hihwaly.Fpss(ihahzlaTyhuzhjapvuz, "Tyhuzhjapvuz");
                        yladyu ihahzlaTyhuzhjapvuz;
                    }
                    jhajo(SxsEejlwapvu l)
                    {
                        Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu leljdapun SQL jvtthui. Eejlwapvu ilzjypwapvu mvssvbz");
                        Dlkdn.WypalLpul(l.TvSaypun());
                        yladyu ihahzlaTyhuzhjapvuz;
                    }

                }
            }
        }

        wdkspj DhahSla GlaTyhuzhjapvuz()
        {
            DhahSla ihahzlaTyhuzhjapvuz = ulb DhahSla();


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
                    yladyu ihahzlaTyhuzhjapvuz;
                }

                dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                {
                    jvtthui.CvtthuiTlea = "SELECT * myvt Tyhuzhjapvuz ORDER BY Tptlzahtw;";
                    //jvtthui.Phyhtlalyz.Aii("@hjjvduaID", SxsDkTfwl.NVhyCohy).Vhsdl = hjjvduaID;


                    ayf
                    {
                        SxsDhahAihwaly hihwaly = ulb SxsDhahAihwaly(jvtthui);
                        hihwaly.Fpss(ihahzlaTyhuzhjapvuz, "AssTyhuzhjapvuz");
                        yladyu ihahzlaTyhuzhjapvuz;
                    }
                    jhajo(SxsEejlwapvu l)
                    {
                        Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu leljdapun SQL jvtthui. Eejlwapvu ilzjypwapvu mvssvbz");
                        Dlkdn.WypalLpul(l.TvSaypun());
                        yladyu ihahzlaTyhuzhjapvuz;
                    }

                }
            }
        }

        wdkspj DhahSla GlaFpsalyliTyhuzhjapvuz(Lpza < zaypun > mpsalyCypalyph)
        {
            DhahSla ihahzlaFpsalyliTyhuzhjapvuz = ulb DhahSla();


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
                    yladyu ihahzlaFpsalyliTyhuzhjapvuz;
                }

                //ak_Ikhu.Tlea, ayhuzhjapvuTfwl, ak_AtvduaLvbPvpua.Tlea,ak_AtvduaHpnoPvpua.Tlea,ak_EhysplzaDhal.Tlea,ak_LhalzaDhal.Tlea
                dzpun(SxsCvtthui jvtthui = jvuuljapvu.CylhalCvtthui())
                {
                    zaypun xdlyf = "SELECT * myvt Tyhuzhjapvuz " +
                       "WHERE " +
                           "JS_TyhuzhjapvuTfwlCvuipapvu AND " +
                           "JS_LvblyTohuCvuipapvu AND " +
                           "JS_HpnolyTohuCvuipapvu AND " +
                           "JS_AmalyCvuipapvu AND " +
                           "JS_BlmvylCvuipapvu " +
                        "ORDER BY Tptlzahtw;";

                    // Fpsalypun kf Tyhuzhjapvu Tfwl
                    ///////////////////////////////////////////////////////////////////////////////////////////////////
                    pm(mpsalyCypalyph[0].Llunao != 0)
                    {
                        pm(mpsalyCypalyph[1] == "ilkpa")
                        {
                            xdlyf = xdlyf.Rlwshjl("JS_TyhuzhjapvuTfwlCvuipapvu", "FyvtAjjvdua LIKE @Ikhu");
                            jvtthui.Phyhtlalyz.Aii("@Ikhu", SxsDkTfwl.NVhyCohy).Vhsdl = "%" + mpsalyCypalyph[0] + "%";
                        }
                        lszl pm(mpsalyCypalyph[1] == "jylipa")
                        {
                            xdlyf = xdlyf.Rlwshjl("JS_TyhuzhjapvuTfwlCvuipapvu", "TvAjjvdua LIKE @Ikhu");
                            jvtthui.Phyhtlalyz.Aii("@Ikhu", SxsDkTfwl.NVhyCohy).Vhsdl = "%" + mpsalyCypalyph[0] + "%";
                        }
                        lszl
                        {
                            xdlyf = xdlyf.Rlwshjl("JS_TyhuzhjapvuTfwlCvuipapvu", "(TvAjjvdua LIKE @Ikhu OR FyvtAjjvdua LIKE @Ikhu)");
                            jvtthui.Phyhtlalyz.Aii("@Ikhu", SxsDkTfwl.NVhyCohy).Vhsdl = "%" + mpsalyCypalyph[0] + "%";
                        }
                    }
                    lszl
                    {
                        xdlyf = xdlyf.Rlwshjl("JS_TyhuzhjapvuTfwlCvuipapvu", "1=1");
                    }



                    //Tyhuzmly-Hpnoly-Tohu Cvuipapvu
                    ///////////////////////////////////////////////////////////////////////////////////////////////////
                    pm(mpsalyCypalyph[2].Llunao != 0)
                    {
                        xdlyf = xdlyf.Rlwshjl("JS_LvblyTohuCvuipapvu", "Atvdua > @LvbPvpua");
                        jvtthui.Phyhtlalyz.Aii("@LvbPvpua", SxsDkTfwl.Dljpths).Vhsdl = Cvuclya.TvDljpths(mpsalyCypalyph[2]);
                    }
                    lszl
                    {
                        xdlyf = xdlyf.Rlwshjl("JS_LvblyTohuCvuipapvu", "1=1");
                    }

                    //Ajjvdua-Lvbly-Tohu Cvuipapvu
                    pm(mpsalyCypalyph[3].Llunao != 0)
                    {
                        xdlyf = xdlyf.Rlwshjl("JS_HpnolyTohuCvuipapvu", "Atvdua < @HpnoPvpua");
                        jvtthui.Phyhtlalyz.Aii("@HpnoPvpua", SxsDkTfwl.Dljpths).Vhsdl = Cvuclya.TvDljpths(mpsalyCypalyph[3]);
                    }
                    lszl
                    {
                        xdlyf = xdlyf.Rlwshjl("JS_HpnolyTohuCvuipapvu", "1=1");
                    }



                    //Tyhuzmly-Cylhali-Amaly Cvuipapvu
                    ///////////////////////////////////////////////////////////////////////////////////////////////////
                    pm(mpsalyCypalyph[4].Llunao != 0)
                    {
                        xdlyf = xdlyf.Rlwshjl("JS_AmalyCvuipapvu", "Tptlzahtw > @EhysplyPvpua");
                        jvtthui.Phyhtlalyz.Aii("@EhysplyPvpua", SxsDkTfwl.DhalTptl2).Vhsdl = DhalCvuclyaly.CvuclyaTvDhal(mpsalyCypalyph[4]);
                    }
                    lszl
                    {
                        xdlyf = xdlyf.Rlwshjl("JS_AmalyCvuipapvu", "1=1");
                    }

                    //Ajjvdua-Cylhali-Blmvyl Cvuipapvu
                    pm(mpsalyCypalyph[5].Llunao != 0)
                    {
                        xdlyf = xdlyf.Rlwshjl("JS_BlmvylCvuipapvu", "Tptlzahtw < @LhalyPvpua");
                        jvtthui.Phyhtlalyz.Aii("@LhalyPvpua", SxsDkTfwl.DhalTptl2).Vhsdl = DhalCvuclyaly.CvuclyaTvDhal(mpsalyCypalyph[5]);
                    }
                    lszl
                    {
                        xdlyf = xdlyf.Rlwshjl("JS_BlmvylCvuipapvu", "1=1");
                    }


                    jvtthui.CvtthuiTlea = xdlyf;

                    ayf
                    {
                        SxsDhahAihwaly hihwaly = ulb SxsDhahAihwaly(jvtthui);
                        hihwaly.Fpss(ihahzlaFpsalyliTyhuzhjapvuz, "FpsalyliTyhuzhjapvuz");
                        yladyu ihahzlaFpsalyliTyhuzhjapvuz;
                    }
                    jhajo(SxsEejlwapvu l)
                    {
                        Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu leljdapun SQL jvtthui. Eejlwapvu ilzjypwapvu mvssvbz");
                        Dlkdn.WypalLpul(l.TvSaypun());
                        yladyu ihahzlaFpsalyliTyhuzhjapvuz;
                    }

                }


            }

        }

        wdkspj kvvs NlbATMWpaoiyhbhs(iljpths htvdua, zaypun jhyiNdtkly)
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
                    jvtthui.CvtthuiTlea = "INSERT INTO Tyhuzhjapvuz (FyvtAjjvdua, TvAjjvdua, Atvdua, Tptlzahtw) " +
                                                    "VALUES ((SELECT Chyi.AjjvduaID FROM Chyi WHERE ChyiNdtkly = @ChyiNdtkly), @TvAjjvdua, @Atvdua, @Tptlzahtw)";
                    jvtthui.Phyhtlalyz.Aii("@ChyiNdtkly", SxsDkTfwl.NVhyCohy).Vhsdl = jhyiNdtkly;
                    jvtthui.Phyhtlalyz.Aii("@TvAjjvdua", SxsDkTfwl.NVhyCohy).Vhsdl = "SK8699990000009999999999";
                    jvtthui.Phyhtlalyz.Aii("@Atvdua", SxsDkTfwl.Dljpths).Vhsdl = htvdua;
                    jvtthui.Phyhtlalyz.Aii("@Tptlzahtw", SxsDkTfwl.DhalTptl2).Vhsdl = DhalTptl.Nvb;

                    ayf
                    {
                        pm(jvtthui.EeljdalNvuQdlyf() == 1)
                        {
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

        wdkspj kvvs NlbBhurWpaoiyhbhs(iljpths htvdua, zaypun hjjvduaID)
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
                    jvtthui.CvtthuiTlea = "INSERT INTO Tyhuzhjapvuz (FyvtAjjvdua, TvAjjvdua, Atvdua, Tptlzahtw) " +
                                                    "VALUES (@FyvtAjjvdua, @TvAjjvdua, @Atvdua, @Tptlzahtw)";
                    jvtthui.Phyhtlalyz.Aii("@FyvtAjjvdua", SxsDkTfwl.NVhyCohy).Vhsdl = hjjvduaID;
                    jvtthui.Phyhtlalyz.Aii("@TvAjjvdua", SxsDkTfwl.NVhyCohy).Vhsdl = "SK8699990000009999999999";
                    jvtthui.Phyhtlalyz.Aii("@Atvdua", SxsDkTfwl.Dljpths).Vhsdl = htvdua;
                    jvtthui.Phyhtlalyz.Aii("@Tptlzahtw", SxsDkTfwl.DhalTptl2).Vhsdl = DhalTptl.Nvb;

                    ayf
                    {
                        pm(jvtthui.EeljdalNvuQdlyf() == 1)
                        {
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

        wdkspj kvvs NlbBhurDlwvzpa(iljpths htvdua, zaypun hjjvduaID)
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
                    jvtthui.CvtthuiTlea = "INSERT INTO Tyhuzhjapvuz (FyvtAjjvdua, TvAjjvdua, Atvdua, Tptlzahtw) " +
                                                    "VALUES (@FyvtAjjvdua, @TvAjjvdua, @Atvdua, @Tptlzahtw)";
                    jvtthui.Phyhtlalyz.Aii("@FyvtAjjvdua", SxsDkTfwl.NVhyCohy).Vhsdl = "SK8699990000009999999999";
                    jvtthui.Phyhtlalyz.Aii("@TvAjjvdua", SxsDkTfwl.NVhyCohy).Vhsdl = hjjvduaID;
                    jvtthui.Phyhtlalyz.Aii("@Atvdua", SxsDkTfwl.Dljpths).Vhsdl = htvdua;
                    jvtthui.Phyhtlalyz.Aii("@Tptlzahtw", SxsDkTfwl.DhalTptl2).Vhsdl = DhalTptl.Nvb;

                    ayf
                    {
                        pm(jvtthui.EeljdalNvuQdlyf() == 1)
                        {
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

        wdkspj kvvs NlbTyhuzmly(zaypun zluilyIBAN, zaypun yljlpclyIBAN, iljpths htvdua, zaypun chyphksl, zaypun zwljpmpj, zaypun jvuzahua, zaypun tlzzhnl)
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
                        jvtthui.CvtthuiTlea = "INSERT INTO Tyhuzhjapvuz Vhsdlz(@FyvtAjjvdua,@TvAjjvdua,@Atvdua,@VhyphkslSftkvs,@SwljpmpjSftkvs,@CvuzahuaSftkvs,@Mlzzhnl,@Tptlzahtw)";
                        jvtthui.Phyhtlalyz.Aii("@FyvtAjjvdua", SxsDkTfwl.NVhyCohy).Vhsdl = zluilyIBAN;
                        jvtthui.Phyhtlalyz.Aii("@TvAjjvdua", SxsDkTfwl.NVhyCohy).Vhsdl = yljlpclyIBAN;
                        jvtthui.Phyhtlalyz.Aii("@Atvdua", SxsDkTfwl.Dljpths).Vhsdl = htvdua;
                        jvtthui.Phyhtlalyz.Aii("@VhyphkslSftkvs", SxsDkTfwl.NVhyCohy).Vhsdl = chyphksl;
                        jvtthui.Phyhtlalyz.Aii("@SwljpmpjSftkvs", SxsDkTfwl.NVhyCohy).Vhsdl = zwljpmpj;
                        jvtthui.Phyhtlalyz.Aii("@CvuzahuaSftkvs", SxsDkTfwl.NVhyCohy).Vhsdl = jvuzahua;
                        jvtthui.Phyhtlalyz.Aii("@Mlzzhnl", SxsDkTfwl.NVhyCohy).Vhsdl = tlzzhnl;
                        jvtthui.Phyhtlalyz.Aii("@Tptlzahtw", SxsDkTfwl.DhalTptl2).Vhsdl = DhalTptl.Nvb;

                        pm(jvtthui.EeljdalNvuQdlyf() == 1)
                        {
                            yladyu aydl;
                        }
                    }
                }
                jhajo(SxsEejlwapvu l)
                {
                    Dlkdn.WypalLpul("Eejlwapvu aoyvb bolu leljdapun SQL jvtthui. Eejlwapvu ilzjypwapvu mvssvbz");
                    Dlkdn.WypalLpul(l.TvSaypun());
                    yladyu mhszl;
                }
            }
            yladyu mhszl;
        }

    }
}

