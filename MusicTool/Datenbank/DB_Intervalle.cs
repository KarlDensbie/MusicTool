using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusicTool;
using MusicTool.Basisklassen;

namespace MusicTool.Datenbank
{
	/// <summary> Klasse       : DB_Intervalle
	/// <para>STATISCHE KLASSE</para>
	/// <para>Datenbank der Intervalle</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	public static class DB_Intervalle
	{
		#region VersionInfo

		private static string zz_klassenName= "DB_Intervalle";
		private static string zz_namespace = "MusicTool.Datenbank";
		private static dType zz_datenTyp = dType.DB_Intervalle;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "3";
		private static string zz_letzteBearbeitung= "2016-10-06  16:22:12";
		private static string zz_ersteBearbeitung= "2016-07-17 10:55.30";
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

		/// <summary>Liste der Intervalle
		/// <para>TYP: bcl_BasisListe von ds_Intervall</para>
		/// </summary>
		private static bcl_BasisListe<ds_Intervall> _liste;

		#endregion Attribute

		#region Konstruktor

		/// <summary> STATISCHER Konstruktor()
		/// <para></para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-17  11:01:25</para>
		/// <para>    ersteBearbeitung : 2016-07-17  11:01:25</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		static DB_Intervalle()
		{
			Init();
		}

		/// <summary> Methode: Init()
		/// <para>Initialisiert die Datenbank mit allen Werten</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 2
		/// <para>    letzteBearbeitung: 2016-10-06  15:45:31</para>
		/// <para>    ersteBearbeitung : 2016-07-17  11:03:19</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		private static void Init()
		{
			_liste = new bcl_BasisListe<ds_Intervall>( -1 , "Liste der Intervalle" , dType.DB_Intervalle , InitIntervalle() );
		}

		/// <summary> Methode: InitIntervalle()
		/// <para>Initialisiert die Datenbank Intervalle mit allen Intervallen</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 2
		/// <para>    letzteBearbeitung: 2016-10-06  16:16:28</para>
		/// <para>    ersteBearbeitung : 2016-07-17  11:06:00</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		private static List<ds_Intervall> InitIntervalle()
		{
			List<ds_Intervall> liste = new List<ds_Intervall>();
			liste.Add( new ds_Intervall( ValidIntervallNamen.getName( eIntervall.Prime ) , eIntervall.Prime , eBasisIntervall.Prime ) );
			liste.Add( new ds_Intervall( ValidIntervallNamen.getName( eIntervall.None_K ) , eIntervall.None_K , eBasisIntervall.None ) );
			liste.Add( new ds_Intervall( ValidIntervallNamen.getName( eIntervall.None_G ) , eIntervall.None_G , eBasisIntervall.None ) );
			liste.Add( new ds_Intervall( ValidIntervallNamen.getName( eIntervall.None_Ü ) , eIntervall.None_Ü , eBasisIntervall.None ) );
			liste.Add( new ds_Intervall( ValidIntervallNamen.getName( eIntervall.Terz_K ) , eIntervall.Terz_K , eBasisIntervall.Terz ) );
			liste.Add( new ds_Intervall( ValidIntervallNamen.getName( eIntervall.Terz_G ) , eIntervall.Terz_G , eBasisIntervall.Terz ) );
			liste.Add( new ds_Intervall( ValidIntervallNamen.getName( eIntervall.Undez_V ) , eIntervall.Undez_V , eBasisIntervall.Undez ) );
			liste.Add( new ds_Intervall( ValidIntervallNamen.getName( eIntervall.Undez ) , eIntervall.Undez , eBasisIntervall.Undez ) );
			liste.Add( new ds_Intervall( ValidIntervallNamen.getName( eIntervall.Undez_Ü ) , eIntervall.Undez_Ü , eBasisIntervall.Undez ) );
			liste.Add( new ds_Intervall( ValidIntervallNamen.getName( eIntervall.Quinte_V ) , eIntervall.Quinte_V , eBasisIntervall.Quinte ) );
			liste.Add( new ds_Intervall( ValidIntervallNamen.getName( eIntervall.Quinte ) , eIntervall.Quinte , eBasisIntervall.Quinte ) );
			liste.Add( new ds_Intervall( ValidIntervallNamen.getName( eIntervall.Quinte_Ü ) , eIntervall.Quinte_Ü , eBasisIntervall.Quinte ) );
			liste.Add( new ds_Intervall( ValidIntervallNamen.getName( eIntervall.Tredez_K ) , eIntervall.Tredez_K , eBasisIntervall.Tredez ) );
			liste.Add( new ds_Intervall( ValidIntervallNamen.getName( eIntervall.Tredez_G ) , eIntervall.Tredez_G , eBasisIntervall.Tredez ) );
			liste.Add( new ds_Intervall( ValidIntervallNamen.getName( eIntervall.Sept_V ) , eIntervall.Sept_V , eBasisIntervall.Sept ) );
			liste.Add( new ds_Intervall( ValidIntervallNamen.getName( eIntervall.Sept_K ) , eIntervall.Sept_K , eBasisIntervall.Sept ) );
			liste.Add( new ds_Intervall( ValidIntervallNamen.getName( eIntervall.Sept_G ) , eIntervall.Sept_G , eBasisIntervall.Sept ) );

			return liste;
		}

		#endregion Konstruktor

		#region Eigenschaften

		/// <summary> Eigenschaft: Intervall_DB
		/// <para>gibt die Liste aller Intervalle aus</para>
		/// <para>TYP: bcl_BasisListe von ds_Intervall</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-10-06  16:19:18</para>
		/// <para>    ersteBearbeitung : 2016-10-06  16:19:18</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <value>
		/// The intervall_ database.
		/// </value>
		public static bcl_BasisListe<ds_Intervall> Intervall_DB { get { return _liste; } }

		#endregion Eigenschaften

		#region Methoden

		#endregion Methoden
	}
}
