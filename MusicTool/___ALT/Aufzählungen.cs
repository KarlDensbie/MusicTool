namespace MusikTool
{
    /// <summary> AUFZÄHLUNG: dType
    /// <para>enthält die Aufzählung der Datentypen dieses Programms</para>
    /// .
    /// <para>    Programmierer    : Michael Pütz</para>
    ///           Version          : 0
    /// <para>    Unterversion     : 2</para>
    ///           Revision         : 3
    /// <para>    letzteBearbeitung: 2016-06-25</para>
    /// <para>    ersteBearbeitung : 2016-05-15</para>
    /// .
    /// <para>    getestet am      : </para>
    /// </summary>
    public enum dType
    {
        TonObj = 0,
        IntervallObj = 1,
        TonartTonObj = 2,
        TonartObj = 3,
		ModusObj = 4,
		AkkordObj = 5,
		FensterObj = 6,
        Tools = 7,
		DB_TonObj = 8,
		DB_IntervallObj = 9,
		DB_TonartenObj = 10,
		DB_ModiObj = 11,
		DB_AkkordeObj = 12,
		enharmObj = 13,
		BasisDataObj=14,
		TonInfoObj = 100,
        x = 255
    }

    /// <summary> AUFZÄHLUNG: eTon
    /// <para>Aufzählung der Tonindizes in der Datenbank Töne</para>
    /// .
    /// <para>    Programmierer    : Michael Pütz</para>
    ///           Version          : 0
    /// <para>    Unterversion     : 1</para>
    ///           Revision         : 1
    /// <para>    letzteBearbeitung: 2016-05-16</para>
    /// <para>    ersteBearbeitung : 2016-05-16</para>
    /// .
    /// <para>    getestet am      : </para>
    /// </summary>
    public enum eTon
    {
        Ceses = 0,
        Ces = 1,
        C = 2,
        Cis = 3,
        Cisis = 4,
        Deses = 5,
        Des = 6,
        D = 7,
        Dis = 8,
        Disis = 9,
        Eses = 10,
        Es = 11,
        E = 12,
        Eis = 13,
        Eisis = 14,
        Feses = 15,
        Fes = 16,
        F = 17,
        Fis = 18,
        Fisis = 19,
        Geses = 20,
        Ges = 21,
        G = 22,
        Gis = 23,
        Gisis = 24,
        Ases = 25,
        As = 26,
        A = 27,
        Ais = 28,
        Aisis = 29,
        Heses = 30,
        B = 31,
        H = 32,
        His = 33,
        Hisis = 34,
        X = 255
    }

    /// <summary> AUFZÄHLUNG: eTHöhe
    /// <para>Aufzählung der Tonhöhen</para>
    /// .
    /// <para>    Programmierer    : Michael Pütz</para>
    ///           Version          : 0
    /// <para>    Unterversion     : 1</para>
    ///           Revision         : 1
    /// <para>    letzteBearbeitung: 2016-05-16</para>
    /// <para>    ersteBearbeitung : 2016-05-16</para>
    /// .
    /// <para>    getestet am      : </para>
    /// </summary>
    public enum eTHöhe
    {
        C = 0,
        Cis = 1,
        D = 2,
        Es = 3,
        E = 4,
        F = 5,
        Fis = 6,
        G = 7,
        As = 8,
        A = 9,
        B = 10,
        H = 11,
        X = 255
    }

    /// <summary> AUFZÄHLUNG: eGrundton
    /// <para>Aufzählung der Grundtöne</para>
    /// .
    /// <para>    Programmierer    : Michael Pütz</para>
    ///           Version          : 0
    /// <para>    Unterversion     : 1</para>
    ///           Revision         : 1
    /// <para>    letzteBearbeitung: 2016-05-16</para>
    /// <para>    ersteBearbeitung : 2016-05-16</para>
    /// .
    /// <para>    getestet am      : </para>
    /// </summary>
    public enum eGrundton
    {
        C = 0,
        D = 1,
        E = 2,
        F = 3,
        G = 4,
        A = 5,
        H = 6,
        X = 255
    }

    /// <summary> AUFZÄHLUNG: eIntervall
    /// <para>Aufzählung der Indizes der Intervalle</para>
    /// .
    /// <para>    Programmierer    : Michael Pütz</para>
    ///           Version          : 0
    /// <para>    Unterversion     : 1</para>
    ///           Revision         : 1
    /// <para>    letzteBearbeitung: 2016-05-17  13:41:43</para>
    /// <para>    ersteBearbeitung : 2016-05-17  13:41:43</para>
    /// .
    /// <para>    getestet am      : </para>
    /// </summary>
    public enum eIntervall
    {
        Prime = 0,
        None_K = 1,
        None_G = 2,
        None_Ü = 3,
        Terz_K = 4,
        Terz_G = 5,
        Undez_V = 6,
        Undez = 7,
        Undez_Ü = 8,
        Quinte_V = 9,
        Quinte = 10,
        Quinte_Ü = 11,
        Tredez_K = 12,
        Tredez_G = 13,
        Sept_V = 14,
        Sept_K = 15,
        Sept_G = 16,
        X = 255
    }

    /// <summary> AUFZÄHLUNG: eBasisIntervall
    /// <para>Aufzählung der Basisintervalle</para>
    /// .
    /// <para>    Programmierer    : Michael Pütz</para>
    ///           Version          : 0
    /// <para>    Unterversion     : 1</para>
    ///           Revision         : 1
    /// <para>    letzteBearbeitung: 2016-05-17  16:17:10</para>
    /// <para>    ersteBearbeitung : 2016-05-17  16:17:10</para>
    /// .
    /// <para>    getestet am      : </para>
    /// </summary>
    public enum eBasisIntervall
    {
        Prime = 0,
        None = 1,
        Terz = 2,
        Undez = 3,
        Quinte = 4,
        Tredez = 5,
        Sept = 6,
        X = 255
    }

    /// <summary> AUFZÄHLUNG: eTonart
    /// <para>Aufzählung der Tonarten</para>
    /// .
    /// <para>    Programmierer    : Michael Pütz</para>
    ///           Version          : 0
    /// <para>    Unterversion     : 1</para>
    ///           Revision         : 1
    /// <para>    letzteBearbeitung: 2016-05-18  22:32:20</para>
    /// <para>    ersteBearbeitung : 2016-05-18  22:32:20</para>
    /// .
    /// <para>    getestet am      : </para>
    /// </summary>
    public enum eTonart
    {
        C = 0,
        Cis = 1,
        Des = 2,
        D = 3,
        Dis = 4,
        Es = 5,
        E = 6,
        F = 7,
        Fis = 8,
        Ges = 9,
        G = 10,
        Gis = 11,
        As = 12,
        A = 13,
        Ais = 14,
        B = 15,
        H = 16
    }

    /// <summary> AUFZÄHLUNG: eStatus
    /// <para>Aufzählung der Status eines gefundenen Tons</para>
    /// .
    /// <para>    Programmierer    : Michael Pütz</para>
    ///           Version          : 0
    /// <para>    Unterversion     : 1</para>
    ///           Revision         : 2
    /// <para>    letzteBearbeitung: 2016-06-01  20:09:32</para>
    /// <para>    ersteBearbeitung : 2016-06-01  20:03:46</para>
    /// .
    /// <para>    getestet am      : </para>
    /// </summary>
    public enum eStatus
    {
        Hauptton = 0,
        enhU,
        enhO,
        unbestimmt = 255
    }

	/// <summary> AUFZÄHLUNG: Ausgabeart
	/// <para>Aufzählung der Ausgabeart</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	///           Version          : 0
	/// <para>    Unterversion     : 1</para>
	///           Revision         : 1
	/// <para>    letzteBearbeitung: 2016-06-18  17:06:39</para>
	/// <para>    ersteBearbeitung : 2016-06-18  17:06:39</para>
	/// .
	/// <para>    getestet am      : </para>
	/// </summary>
	public enum Ausgabeart
	{
		Datei,
		zwischenwerte,
		Ergebnisse
	}

	/// <summary> AUFZÄHLUNG: dataType
	/// <para>Aufzählung der Datentypen</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	///           Version          : 0
	/// <para>    Unterversion     : 1</para>
	///           Revision         : 1
	/// <para>    letzteBearbeitung: 2016-06-18  17:06:39</para>
	/// <para>    ersteBearbeitung : 2016-06-18  17:06:39</para>
	/// .
	/// <para>    getestet am      : </para>
	/// </summary>
	public enum dataType
	{
		genBasisdaten = 0,
		genListe = 1,
		Datenbank = 2,
		Ton = 3,
		DB_Töne = 4,
		Intervall = 5,
		DB_Intervalle = 6,
		Tonart = 7,
		DB_Tonarten = 8
	}

    // ----------------------------------------------------------------------------------------------------

    /// <summary> Klasse       : Aufzählungen
    /// <para>enthält alle Aufzählungen und Funktionen der Aufzählungen</para>
    /// .
    /// <para>    Programmierer    : Michael Pütz</para>
    ///           Version          : 0
    /// <para>    Unterversion     : 1</para>
    ///           Revision         : 4
    /// <para>    letzteBearbeitung: 2016-05-17  18:25:19</para>
    /// <para>    ersteBearbeitung : 2016-05-15</para>
    /// .
    /// <para>    getestet am      : </para>
    /// </summary>
    public static class Aufzählungen
    {
        #region VersionInfo
        private static string zz_klassenName= "Aufzählungen";
        private static string zz_namespace = "MusicTool";
        private static dType zz_datenTyp = dType.x;
        private static string zz_hauptversion= "0";
        private static string zz_nebenversion= "1";
        private static string zz_revision= "4";
        private static string zz_letzteBearbeitung= "2016-05-17  18:25:32";
        private static string zz_ersteBearbeitung= "2016-05-15 20:22.28";
        public static string zzKlassenName { get { return zz_klassenName; } }
        public static string zz_Namespace { get { return zz_namespace; } }
        public static string zz_VersionInfo
        {
            get {
                return "Version: " + zz_hauptversion + "." + zz_nebenversion +
              ", Revision: " + zz_revision;
            }
        }
        public static string zz_AktBearbeitung { get { return zz_letzteBearbeitung; } }
        public static string zz_BearbeitungsBeginn { get { return zz_ersteBearbeitung; } }
        public static dType zz_DatenTyp { get { return zz_datenTyp; } }
        #endregion VersionInfo

        /// <summary> Klassen-Methode: get_dType(index)
        /// <para>gibt den Typ-Namen aus</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 3
		/// <para>    letzteBearbeitung: 2016-06-26  13:50:26</para>
		/// <para>    ersteBearbeitung : 2016-05-15</para>
		/// .
		/// <para>    getestet am      : </para>
        /// </summary>
        /// <param name="index">Index des Typ-Namens, TYP: INT</param>
        /// <returns>Typ-Name, TYP: dType</returns>
        public static dType get_dType( int index )
        {
            dType tmp;

            switch( index ) {
                case 0:
                    tmp = dType.TonObj;
                    break;
                case 1:
                    tmp = dType.IntervallObj;
                    break;
                case 2:
                    tmp = dType.TonartTonObj;
                    break;
                case 3:
                    tmp = dType.TonartObj;
                    break;
                case 4:
                    tmp = dType.ModusObj;
                    break;
                case 5:
                    tmp = dType.AkkordObj;
                    break;
                case 6:
                    tmp = dType.FensterObj;
                    break;
                case 7:
                    tmp = dType.Tools;
                    break;
                case 8:
                    tmp = dType.DB_TonObj;
                    break;
                case 9:
                    tmp = dType.DB_IntervallObj;
                    break;
                case 10:
                    tmp = dType.DB_TonartenObj;
                    break;
                case 11:
                    tmp = dType.DB_ModiObj;
                    break;
                case 12:
                    tmp = dType.DB_AkkordeObj;
                    break;
                case 13:
                    tmp = dType.enharmObj;
                    break;
				case 14:
					tmp = dType.BasisDataObj;
					break;
                case 100:
                    tmp = dType.TonInfoObj;
                    break;
                default:
                    tmp = dType.x;
                    break;
            }

            return tmp;
        }

        /// <summary> Klassen-Methode: get_eTon(index)
        /// <para>gibt den Typ-Namen aus</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-05-17  16:35:10</para>
		/// <para>    ersteBearbeitung : 2016-05-17  16:35:10</para>
		/// .
		/// <para>    getestet am      : </para>
        /// </summary>
        /// <param name="index">Index des Typ-Namens, TYP: INT</param>
        /// <returns>Typ-Name, TYP: eTon</returns>
        public static eTon get_eTon( int index )
        {
            eTon tmp;

            switch( index ) {
                case 0:
                    tmp = eTon.Ceses;
                    break;
                case 1:
                    tmp = eTon.Ces;
                    break;
                case 2:
                    tmp = eTon.C;
                    break;
                case 3:
                    tmp = eTon.Cis;
                    break;
                case 4:
                    tmp = eTon.Cisis;
                    break;
                case 5:
                    tmp = eTon.Deses;
                    break;
                case 6:
                    tmp = eTon.Des;
                    break;
                case 7:
                    tmp = eTon.D;
                    break;
                case 8:
                    tmp = eTon.Dis;
                    break;
                case 9:
                    tmp = eTon.Disis;
                    break;
                case 10:
                    tmp = eTon.Eses;
                    break;
                case 11:
                    tmp = eTon.Es;
                    break;
                case 12:
                    tmp = eTon.E;
                    break;
                case 13:
                    tmp = eTon.Eis;
                    break;
                case 14:
                    tmp = eTon.Eisis;
                    break;
                case 15:
                    tmp = eTon.Feses;
                    break;
                case 16:
                    tmp = eTon.Fes;
                    break;
                case 17:
                    tmp = eTon.F;
                    break;
                case 18:
                    tmp = eTon.Fis;
                    break;
                case 19:
                    tmp = eTon.Fisis;
                    break;
                case 20:
                    tmp = eTon.Geses;
                    break;
                case 21:
                    tmp = eTon.Ges;
                    break;
                case 22:
                    tmp = eTon.G;
                    break;
                case 23:
                    tmp = eTon.Gis;
                    break;
                case 24:
                    tmp = eTon.Gisis;
                    break;
                case 25:
                    tmp = eTon.Ases;
                    break;
                case 26:
                    tmp = eTon.As;
                    break;
                case 27:
                    tmp = eTon.A;
                    break;
                case 28:
                    tmp = eTon.Ais;
                    break;
                case 29:
                    tmp = eTon.Aisis;
                    break;
                case 30:
                    tmp = eTon.Heses;
                    break;
                case 31:
                    tmp = eTon.B;
                    break;
                case 32:
                    tmp = eTon.H;
                    break;
                case 33:
                    tmp = eTon.His;
                    break;
                case 34:
                    tmp = eTon.Hisis;
                    break;
                default:
                    tmp = eTon.X;
                    break;
            }

            return tmp;
        }

        /// <summary> Klassen-Methode: get_eTHöhe(index)
        /// <para>gibt den Typ-Namen aus</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-05-17  16:43:20</para>
		/// <para>    ersteBearbeitung : 2016-05-17  16:43:20</para>
		/// .
		/// <para>    getestet am      : </para>
        /// </summary>
        /// <param name="index">Index des Typ-Namens, TYP: INT</param>
        /// <returns>Typ-Name, TYP: eTHöhe</returns>
        public static eTHöhe get_eTHöhe( int index )
        {
            eTHöhe tmp;

            switch( index ) {
                case 0:
                    tmp = eTHöhe.C;
                    break;
                case 1:
                    tmp = eTHöhe.Cis;
                    break;
                case 2:
                    tmp = eTHöhe.D;
                    break;
                case 3:
                    tmp = eTHöhe.Es;
                    break;
                case 4:
                    tmp = eTHöhe.E;
                    break;
                case 5:
                    tmp = eTHöhe.F;
                    break;
                case 6:
                    tmp = eTHöhe.Fis;
                    break;
                case 7:
                    tmp = eTHöhe.G;
                    break;
                case 8:
                    tmp = eTHöhe.As;
                    break;
                case 9:
                    tmp = eTHöhe.A;
                    break;
                case 10:
                    tmp = eTHöhe.B;
                    break;
                case 11:
                    tmp = eTHöhe.H;
                    break;
                default:
                    tmp = eTHöhe.X;
                    break;
            }

            return tmp;
        }

        /// <summary> Klassen-Methode: get_eGrundton(index)
        /// <para>gibt den Typ-Namen aus</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-05-17  16:43:20</para>
		/// <para>    ersteBearbeitung : 2016-05-17  16:43:20</para>
		/// .
		/// <para>    getestet am      : </para>
        /// </summary>
        /// <param name="index">Index des Typ-Namens, TYP: INT</param>
        /// <returns>Typ-Name, TYP: eGrundton</returns>
        public static eGrundton get_eGrundton( int index )
        {
            eGrundton tmp;

            switch( index ) {
                case 0:
                    tmp = eGrundton.C;
                    break;
                case 1:
                    tmp = eGrundton.D;
                    break;
                case 2:
                    tmp = eGrundton.E;
                    break;
                case 3:
                    tmp = eGrundton.F;
                    break;
                case 4:
                    tmp = eGrundton.G;
                    break;
                case 5:
                    tmp = eGrundton.A;
                    break;
                case 6:
                    tmp = eGrundton.H;
                    break;
                default:
                    tmp = eGrundton.X;
                    break;
            }

            return tmp;
        }

        /// <summary> Klassen-Methode: get_eIntervall(index)
        /// <para>gibt den Typ-Namen aus</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-05-17  17:00:35</para>
		/// <para>    ersteBearbeitung : 2016-05-17  17:00:35</para>
		/// .
		/// <para>    getestet am      : </para>
        /// </summary>
        /// <param name="index">Index des Typ-Namens, TYP: INT</param>
        /// <returns>Typ-Name, TYP: eIntervall</returns>
        public static eIntervall get_eIntervall( int index )
        {
            eIntervall tmp;

            switch( index ) {
                case 0:
                    tmp = eIntervall.Prime;
                    break;
                case 1:
                    tmp = eIntervall.None_K;
                    break;
                case 2:
                    tmp = eIntervall.None_G;
                    break;
                case 3:
                    tmp = eIntervall.None_Ü;
                    break;
                case 4:
                    tmp = eIntervall.Terz_K;
                    break;
                case 5:
                    tmp = eIntervall.Terz_G;
                    break;
                case 6:
                    tmp = eIntervall.Undez_V;
                    break;
                case 7:
                    tmp = eIntervall.Undez;
                    break;
                case 8:
                    tmp = eIntervall.Undez_Ü;
                    break;
                case 9:
                    tmp = eIntervall.Quinte_V;
                    break;
                case 10:
                    tmp = eIntervall.Quinte;
                    break;
                case 11:
                    tmp = eIntervall.Quinte_Ü;
                    break;
                case 12:
                    tmp = eIntervall.Tredez_K;
                    break;
                case 13:
                    tmp = eIntervall.Tredez_G;
                    break;
                case 14:
                    tmp = eIntervall.Sept_V;
                    break;
                case 15:
                    tmp = eIntervall.Sept_K;
                    break;
                case 16:
                    tmp = eIntervall.Sept_G;
                    break;
                default:
                    tmp = eIntervall.X;
                    break;
            }

            return tmp;
        }

        /// <summary> Klassen-Methode: get_eBasisIntervall(index)
        /// <para>gibt den Typ-Namen aus</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-05-17  17:07:30</para>
		/// <para>    ersteBearbeitung : 2016-05-17  17:07:30</para>
		/// .
		/// <para>    getestet am      : </para>
        /// </summary>
        /// <param name="index">Index des Typ-Namens, TYP: INT</param>
        /// <returns>Typ-Name, TYP: eBasisIntervall</returns>
        public static eBasisIntervall get_eBasisIntervall( int index )
        {
            eBasisIntervall tmp;

            switch( index ) {
                case 0:
                    tmp = eBasisIntervall.Prime;
                    break;
                case 1:
                    tmp = eBasisIntervall.None;
                    break;
                case 2:
                    tmp = eBasisIntervall.Terz;
                    break;
                case 3:
                    tmp = eBasisIntervall.Undez;
                    break;
                case 4:
                    tmp = eBasisIntervall.Quinte;
                    break;
                case 5:
                    tmp = eBasisIntervall.Tredez;
                    break;
                case 6:
                    tmp = eBasisIntervall.Sept;
                    break;
                default:
                    tmp = eBasisIntervall.X;
                    break;
            }

            return tmp;
        }
    }

}
