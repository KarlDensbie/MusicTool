using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusikTool;
using MusikTool.Basisklassen;

namespace MusikTool.Basisklassen
{
	/// <summary> Klasse       : bcl_Intervall
	/// <para>speichert alle Daten eines Intervalls</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>

	public class bcl_Intervall:bcl_gen_Basisdata<eIntervall>
	{
		#region VersionInfo

		private static string zz_klassenName= "bcl_Intervall";
		private static string zz_namespace = "MusikTool.Basisklassen";
		private static dataType zz_datenTyp = dataType.Intervall;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "1";
		private static string zz_letzteBearbeitung= "2016-06-26  19:09:02";
		private static string zz_ersteBearbeitung= "2016-06-26 19:05.03";
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

		public bcl_Intervall(string name, eIntervall id ) : base( name , id ) { }

		#endregion Konstruktor

	}
}
