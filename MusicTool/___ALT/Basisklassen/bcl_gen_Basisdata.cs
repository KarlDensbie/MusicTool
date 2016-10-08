using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusikTool;

namespace MusikTool.Basisklassen
{
	/// <summary> Klasse       : bcl_gen_Basisdata<T>
	/// <para>zur Speicherung der Basisdaten von Tönen und Intervallen</para>
	/// <para>das Typparameter ist der Datentyp der Indizes</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>

	public class bcl_gen_Basisdata <T>
	{
		#region VersionInfo

		private static string zz_klassenName= "bcl_gen_Basisdata<T>";
		private static string zz_namespace = "MusikTool.Basisklassen";
		private static dataType zz_datenTyp = dataType.genBasisdaten;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "1";
		private static string zz_letzteBearbeitung= "2016-06-26  17:28:09";
		private static string zz_ersteBearbeitung= "2016-06-26 16:36.06";
		private static string zz_getestet= "";
		#region VersionInfoEigenschaften
		public static string zz_KlassenName { get { return zz_klassenName; } }
		public static string zz_Namespace { get { return zz_namespace; } }
		public static string zz_Pfad { get { return zz_namespace + "." + zz_klassenName; } }
		public static string zz_VersionInfo
		{
			get {
				return "Version: " + zz_hauptversion + "." + zz_nebenversion +
			  ", Revision: " + zz_revision;
			}
		}
		public static string zz_AktBearbeitung { get { return zz_letzteBearbeitung; } }
		public static string zz_BearbeitungsBeginn { get { return zz_ersteBearbeitung; } }
		public static dataType zz_DatenTyp { get { return zz_datenTyp; } }
		public static string zz_Getestet { get { return zz_getestet; } }
		#endregion VersionInfoEigenschaften

		#endregion VersionInfo

		#region Attribute

		/// <summary>Name des Tons/Intervalls
		/// <para>TYP: STRING</para>
		/// </summary>
		private string _name;

		/// <summary>ID des Tons/Intervalls
		/// <para>TYP: T(wird zur Laufzeit festgelegt)</para>
		/// </summary>
		private T _id;

		#endregion Attribute

		#region Konstruktor

		/// <summary> Konstruktor(name,T id)
		/// <para>initialisiert die Instanz mit allen Daten</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-06-26  17:08:07</para>
		/// <para>    ersteBearbeitung : 2016-06-26  17:08:07</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="name">Name des Tons/Intervalls, TYP: STRING</param>
		/// <param name="id">ID des Tons/Intervalls, TYP: T</param>
		public bcl_gen_Basisdata(string name,T id )
		{
			_name = name;
			_id = id;
		}

		#endregion Konstruktor

		#region Eigenschaften

		/// <summary> Eigenschaft: Name
		/// <para>gibt den Namen des Tons/Intervalls aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-06-26  16:59:37</para>
		/// <para>    ersteBearbeitung : 2016-06-26  16:59:37</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public string Name { get { return _name; } }

		/// <summary> Eigenschaft: 
		/// <para>gibt die ID des Tons/Intervalls aus</para>
		/// <para>TYP: T(wird zur Laufzeit festgelegt)</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-06-26  17:00:52</para>
		/// <para>    ersteBearbeitung : 2016-06-26  17:00:52</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public T ID { get { return _id; } }

		#endregion Eigenschaften
	}
}
