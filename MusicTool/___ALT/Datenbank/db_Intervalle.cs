using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusikTool;
using MusikTool.Basisklassen;

namespace MusikTool.Datenbank
{
	/// <summary> Klasse       : db_Intervalle
	/// <para>Datenbank der Inetervalle</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>

	public class db_Intervalle : bcl_gen_Liste<bcl_Intervall>
	{
		#region VersionInfo

		private static string zz_klassenName= "db_Intervalle";
		private static string zz_namespace = "MusikTool.Datenbank";
		private static dataType zz_datenTyp = dataType.DB_Intervalle;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "3";
		private static string zz_letzteBearbeitung= "2016-06-26  22:00:44";
		private static string zz_ersteBearbeitung= "2016-06-26 19:11.00";
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

		/// <summary> Konstruktor(parameter)
		/// <para>initialisiert die Datenbank Intervalle mit allen Werten</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 3
		/// <para>    letzteBearbeitung: 2016-06-26  22:00:14</para>
		/// <para>    ersteBearbeitung : 2016-06-26  21:30:49</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public db_Intervalle( params bcl_Intervall[] parameter ) : base( "" , -1 , parameter ) { }

		#endregion Konstruktor

		#region Methoden

		public bcl_Intervall get( eIntervall id ) { return get( (int)id ); }

		#endregion Methoden

	}
}
