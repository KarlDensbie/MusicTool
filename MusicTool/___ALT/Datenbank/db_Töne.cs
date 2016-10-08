using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusikTool;
using MusikTool.Basisklassen;

namespace MusikTool.Datenbank
{
	/// <summary> Klasse       : db_Töne
	/// <para>Datenbank der Töne</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>

	public class db_Töne : bcl_gen_Liste<bcl_Ton>
	{
		#region VersionInfo

		private static string zz_klassenName= "db_Töne";
		private static string zz_namespace = "MusikTool.Datenbank";
		private static dataType zz_datenTyp = dataType.DB_Töne;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "4";
		private static string zz_letzteBearbeitung= "2016-06-26  21:59:18";
		private static string zz_ersteBearbeitung= "2016-06-26 18:07.53";
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
		/// <para>initialisiert die Datenbank Töne mit allen Werten</para>
		/// Da die Datenbank keinen Index braucht, wird der Index auf -1 gesetzt
		/// <para>.</para>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 3
		/// <para>    letzteBearbeitung: 2016-06-26  21:58:50</para>
		/// <para>    ersteBearbeitung : 2016-06-26  21:35:04</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="name">Name der </param>
		/// <param name="parameter">alle Member der Datenbank, TYP: ARRAY von bcl_Ton</param>
		public db_Töne( params bcl_Ton[] parameter ) : base( "" , -1 , parameter ) { }

		#endregion Konstruktor

		#region Methoden

		/// <summary> Methode: get(id)
		/// <para>gibt ein Ton-Objekt aus</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-06-26  21:45:05</para>
		/// <para>    ersteBearbeitung : 2016-06-26  21:45:05</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="id">ID des Tons, TYP: eTon</param>
		/// <returns>Ton-Objekt, TYP: bcl_Ton</returns>
		public bcl_Ton get( eTon id ) {return get( (int)id ); }

		#endregion Methoden

	}
}
