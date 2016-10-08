using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusikTool;
using MusikTool.Basisklassen;

namespace MusikTool.Basisklassen
{
	/// <summary> Klasse       : bcl_Tonart
	/// <para>speichert alle Töne einer Tonart</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>

	public class bcl_Tonart:bcl_gen_Liste<bcl_Ton>
	{
		#region VersionInfo

		private static string zz_klassenName= "bcl_Tonart";
		private static string zz_namespace = "MusikTool.Basisklassen";
		private static dataType zz_datenTyp = dataType.Tonart;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "2";
		private static string zz_letzteBearbeitung= "2016-06-26  22:07:24";
		private static string zz_ersteBearbeitung= "2016-06-26 19:27.46";
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
		/// <para>Initialisiert die Tonart</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-06-26  22:06:07</para>
		/// <para>    ersteBearbeitung : 2016-06-26  22:06:07</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public bcl_Tonart( string name , int id , params bcl_Ton[] parameter ) : base( name , id , parameter ) { }

		#endregion Konstruktor

	}
}
