using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusikTool;
using MusikTool.Basisklassen;

namespace MusikTool.Basisklassen
{
	/// <summary> Klasse       : bcl_Ton
	/// <para>Speichert die Daten eines Tons</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>

	public class bcl_Ton:bcl_gen_Basisdata<eTon>
	{
		#region VersionInfo

		private static string zz_klassenName= "bcl_Ton";
		private static string zz_namespace = "MusikTool.Basisklassen";
		private static dataType zz_datenTyp = dataType.Ton;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "1";
		private static string zz_letzteBearbeitung= "2016-06-26 18:36.33";
		private static string zz_ersteBearbeitung= "2016-06-26 18:36.33";
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

		public bcl_Ton(string name, eTon id ) : base( name , id ) { }

		#endregion Konstruktor

	}
}
