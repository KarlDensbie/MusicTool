using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusicTool;
using MusicTool.Basisklassen;

namespace MusicTool.Datenbank
{
	/// <summary> Klasse       : DB_Töene
	/// <para>STATISCHE KLASSE</para>
	/// <para>Datenbank Töne</para>
	/// <para>speichert alle Töne</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	public static class DB_Töene
	{
		#region VersionInfo

		private static string zz_klassenName= "DB_Töene";
		private static string zz_namespace = "MusicTool.Datenbank";
		private static dType zz_datenTyp = dType.DB_Töne;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "2";
		private static string zz_letzteBearbeitung= "2016-10-06  16:04:57";
		private static string zz_ersteBearbeitung= "2016-07-10 18:22.35";
		private static string zz_getestet= "";
		#region VersionInfoEigenschaften
		public static string zz_KlassenName { get { return zz_klassenName; } }
		/// <summary> Eigenschaft: zz_KlassenName
		/// <para>gibt den Namen der Klasse aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  12:31:43</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:31:43</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <summary> Eigenschaft: zz_Namespace
		/// <para>gibt den Namespace der Klasse aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  12:32:38</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:32:38</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static string zz_Namespace { get { return zz_namespace; } }
		/// <summary> Eigenschaft: zz_Pfad
		/// <para>gibt den Pfad (Namespace + Klassenname) aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  12:33:31</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:33:31</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static string zz_Pfad { get { return zz_namespace + "." + zz_klassenName; } }
		/// <summary> Eigenschaft: zz_VersionInfo
		/// <para>gibt die Version der Klasse aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  12:34:43</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:34:43</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static string zz_VersionInfo
		{
			get {
				return "Version: " + zz_hauptversion + "." + zz_nebenversion +
			  ", Revision: " + zz_revision;
			}
		}
		/// <summary> Eigenschaft: zz_AktBearbeitung
		/// <para>gibt das Datum der letzten Bearbeitung der Klasse aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  12:35:45</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:35:45</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static string zz_AktBearbeitung { get { return zz_letzteBearbeitung; } }
		/// <summary> Eigenschaft: zz_BearbeitungsBeginn
		/// <para>gibt aus, ab wann diese Klasse programmiert wurde</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  12:36:44</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:36:44</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static string zz_BearbeitungsBeginn { get { return zz_ersteBearbeitung; } }
		/// <summary> Eigenschaft: zz_DatenTyp
		/// <para>gibt den Datentyp der Klasse aus</para>
		/// <para>TYP: dType</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  12:37:35</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:37:35</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static dType zz_DatenTyp { get { return zz_datenTyp; } }
		/// <summary> Eigenschaft: zz_Getestet
		/// <para>gibt aus, wann die Klasse getestet wurde</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  12:43:07</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:43:07</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static string zz_Getestet { get { return zz_getestet; } }
		#endregion VersionInfoEigenschaften

		#endregion VersionInfo

		#region Attribute

		/// <summary>Liste der Töne
		/// <para>enthält sämtliche Töne</para>
		/// <para>TYP: bcl_BasisListe von ds_Ton</para>
		/// </summary>
		private static bcl_BasisListe<ds_Ton> _liste;

		#endregion Attribute

		#region Konstruktor

		/// <summary> STATISCHER Konstruktor()
		/// <para></para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  18:26:06</para>
		/// <para>    ersteBearbeitung : 2016-07-10  18:26:06</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		static DB_Töene()
		{
			//_liste = new bcl_BasisListe<ds_Ton>( -1 , "Liste der Töne" , dType.DB_Töne );
			Init();
		}

		/// <summary> Methode: Init()
		/// <para>Initialisiert die Datenbak Töne mit allen Werten</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 3
		/// <para>    letzteBearbeitung: 2016-10-06  14:56:51</para>
		/// <para>    ersteBearbeitung : 2016-07-10  18:34:08</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		private static void Init()
		{
			_liste = new bcl_BasisListe<ds_Ton>( -1 , "Liste der Töne" , dType.DB_Töne , InitListe() );
		}

		/// <summary> Methode: Init(tonArray)
		/// <para>Initialisiert die Datenbank Töne mit allen Tönen</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 3
		/// <para>    letzteBearbeitung: 2016-10-06  16:04:30</para>
		/// <para>    ersteBearbeitung : 2016-07-10  19:22:48</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		private static List<ds_Ton> InitListe()
		{
			List<ds_Ton> tonListe = new List<ds_Ton>();

			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Ceses ) , eTon.Ceses , eGrundton.C , eTon.Ais , eTon.B , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Ces ) , eTon.Ces , eGrundton.C , eTon.Aisis , eTon.H , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.C ) , eTon.C , eGrundton.C , eTon.His , eTon.Deses , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Cis ) , eTon.Cis , eGrundton.C , eTon.Hisis , eTon.Des , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Cisis ) , eTon.Cisis , eGrundton.C , eTon.D , eTon.Eses , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Deses ) , eTon.Deses , eGrundton.D , eTon.His , eTon.C , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Des ) , eTon.Des , eGrundton.D , eTon.Hisis , eTon.Cis , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.D ) , eTon.D , eGrundton.D , eTon.Cisis , eTon.Eses , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Dis ) , eTon.Dis , eGrundton.D , eTon.Es , eTon.Feses , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Disis ) , eTon.Disis , eGrundton.D , eTon.E , eTon.Fes , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Eses ) , eTon.Eses , eGrundton.E , eTon.Cisis , eTon.D , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Es ) , eTon.Es , eGrundton.E , eTon.Dis , eTon.Feses , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.E ) , eTon.E , eGrundton.E , eTon.Disis , eTon.Fes , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Eis ) , eTon.Eis , eGrundton.E , eTon.F , eTon.Geses , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Eisis ) , eTon.Eisis , eGrundton.E , eTon.Fis , eTon.Ges , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Feses ) , eTon.Feses , eGrundton.F , eTon.Dis , eTon.Es , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Fes ) , eTon.Fes , eGrundton.F , eTon.Disis , eTon.E , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.F ) , eTon.F , eGrundton.F , eTon.Eis , eTon.Geses , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Fis ) , eTon.Fis , eGrundton.F , eTon.Eisis , eTon.Ges , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Fisis ) , eTon.Fisis , eGrundton.F , eTon.G , eTon.Ases , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Geses ) , eTon.Geses , eGrundton.G , eTon.Eis , eTon.F , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Ges ) , eTon.Ges , eGrundton.G , eTon.Eisis , eTon.Fis , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.G ) , eTon.G , eGrundton.G , eTon.Fisis , eTon.Ases , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Gis ) , eTon.Gis , eGrundton.G , eTon.As , eTon.As , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Gisis ) , eTon.Gisis , eGrundton.G , eTon.A , eTon.Heses , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Ases ) , eTon.Ases , eGrundton.A , eTon.Fisis , eTon.G , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.As ) , eTon.As , eGrundton.A , eTon.Gis , eTon.Gis , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.A ) , eTon.A , eGrundton.A , eTon.Gisis , eTon.Heses , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Ais ) , eTon.Ais , eGrundton.A , eTon.B , eTon.Ceses , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Aisis ) , eTon.Aisis , eGrundton.A , eTon.H , eTon.Ces , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Heses ) , eTon.Heses , eGrundton.H , eTon.Gisis , eTon.A , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.B ) , eTon.B , eGrundton.H , eTon.Ais , eTon.Ceses , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.H ) , eTon.H , eGrundton.H , eTon.Aisis , eTon.Ces , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.His ) , eTon.His , eGrundton.H , eTon.C , eTon.Deses , dType.Tondaten ) );
			tonListe.Add( new ds_Ton( ValidTonNamen.getName( eTon.Hisis ) , eTon.Hisis , eGrundton.H , eTon.Cis , eTon.Des , dType.Tondaten ) );

			return tonListe;
		}

		#endregion Konstruktor

		#region Eigenschaften

		/// <summary> Eigenschaft: DB_Töne
		/// <para>gibt die Datenbank der Töne aus</para>
		/// <para>TYP: bcl_BasisListe von ds_Ton</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  19:29:39</para>
		/// <para>    ersteBearbeitung : 2016-07-10  19:29:39</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static bcl_BasisListe<ds_Ton> Ton_DB { get { return _liste; } }

		#endregion Eigenschaften

		#region Methoden

		#endregion Methoden
	}
}
