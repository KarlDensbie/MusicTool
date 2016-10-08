using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTool.Basisklassen
{
	/// <summary> Klasse       : bcl_Basisdaten
	/// <para></para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	public class bcl_Basisdaten
	{
		#region VersionInfo

		private static string zz_klassenName= "bcl_Basisdaten";
		private static string zz_namespace = "MusicTool.Basisklassen";
		private static dType zz_datenTyp = dType.Basisdaten;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "1";
		private static string zz_letzteBearbeitung= "2016-07-10  13:15:03";
		private static string zz_ersteBearbeitung= "2016-07-10 12:30.26";
		private static string zz_getestet= "";
		#region VersionInfoEigenschaften

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
		public static string zz_KlassenName { get { return zz_klassenName; } }

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

		/// <summary>Datentyp der Klasse (abgeleiteten Klasse)
		/// <para>TYP: dType</para>
		/// </summary>
		private dType _typ;

		/// <summary>Name des Datensatzes
		/// <para>TYP: STRING</para>
		/// </summary>
		private string _name;

		/// <summary>2.Name des Datensatzes
		/// <para>TYP: STRING</para>
		/// </summary>
		private string _name2;

		/// <summary>Datensatz-Nummer
		/// <para>TYP: INT</para>
		/// </summary>
		private int _nr;

		#endregion Attribute

		#region Konstruktor

		/// <summary> Konstruktor(name,name2,nr,typ)
		/// <para>initialisiert die Basisklasse mit Namen, 2.Nqamen, Datensatz-Nummer und Typ der abgeleitetetn Klasse</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  13:14:30</para>
		/// <para>    ersteBearbeitung : 2016-07-10  13:09:55</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="name">Name des abgeleiteten Datensatzes, TYP: STRING</param>
		/// <param name="name2">2.Name des abgeleiteten Datensatzes, TYP: STRING</param>
		/// <param name="nr">Datensatz-Nummer, TYP: INT</param>
		/// <param name="typ">Datentyp des Datensatzes, TYP: dType</param>
		public bcl_Basisdaten( string name , string name2 , int nr , dType typ )
		{
			_name = name;
			_name2 = name2;
			_nr = nr;
			_typ = typ;
		}

		#endregion Konstruktor

		#region Eigenschaften

		/// <summary> Eigenschaft: Datentyp
		/// <para>gibt den Datentyp der (abgeleiteten) Klasse aus</para>
		/// <para>TYP: dType</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  12:53:43</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:53:43</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public dType Datentyp { get { return _typ; } }

		/// <summary> Eigenschaft: Name
		/// <para>gibt den Namen des Datensatzes aus</para>
		/// <para></para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  13:05:04</para>
		/// <para>    ersteBearbeitung : 2016-07-10  13:05:04</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public string Name { get { return _name; } }

		/// <summary> Eigenschaft: Name
		/// <para>gibt den 2.Namen des Datensatzes aus</para>
		/// <para></para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  13:05:04</para>
		/// <para>    ersteBearbeitung : 2016-07-10  13:05:04</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public string Name2 { get { return _name2; } }

		/// <summary> Eigenschaft: Nr
		/// <para>gibt die Datensatz-Nummer aus</para>
		/// <para>TYP: INT</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  13:08:10</para>
		/// <para>    ersteBearbeitung : 2016-07-10  13:08:10</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public int Nr { get { return _nr; } }

		#endregion Eigenschaften
	}
}
