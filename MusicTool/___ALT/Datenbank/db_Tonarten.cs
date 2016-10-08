using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusikTool;
using MusikTool.Basisklassen;

namespace MusikTool.Datenbank
{
	/// <summary> Klasse       : db_Tonarten
	/// <para>Datenbank der Tonarten</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>

	public class db_Tonarten:bcl_gen_Liste<bcl_Tonart>
	{
		#region VersionInfo

		private static string zz_klassenName= "db_Tonarten";
		private static string zz_namespace = "MusikTool.Datenbank";
		private static dataType zz_datenTyp = dataType.DB_Tonarten;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "2";
		private static string zz_letzteBearbeitung= "2016-06-26  22:05:07";
		private static string zz_ersteBearbeitung= "2016-06-26 19:33.35";
		private static string zz_getestet= "";
		#region VersionInfoEigenschaften
		public static new string zz_KlassenName { get { return zz_klassenName; } }
		public static new string zz_Namespace { get { return zz_namespace; } }
		public static new string zz_Pfad { get { return zz_namespace + "." + zz_klassenName; } }
		public static new string zz_VersionInfo
		{
			get {
				return "Version: " + zz_hauptversion + "." + zz_nebenversion +
			  ", Revision: " + zz_revision;
			}
		}
		public static new string zz_AktBearbeitung { get { return zz_letzteBearbeitung; } }
		public static new string zz_BearbeitungsBeginn { get { return zz_ersteBearbeitung; } }
		public static new dataType zz_DatenTyp { get { return zz_datenTyp; } }
		public static new string zz_Getestet { get { return zz_getestet; } }
		#endregion VersionInfoEigenschaften

		#endregion VersionInfo

		#region Konstruktor

		/// <summary> Konstruktor(name,id,parameter)
		/// <para>Initialisiert die Datenbank Tonarten</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-06-26  22:03:14</para>
		/// <para>    ersteBearbeitung : 2016-06-26  22:03:14</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public db_Tonarten( string name , int id , params bcl_Tonart[] parameter ) : base( name , id , parameter ) { }

		#endregion Konstruktor

	}
}
