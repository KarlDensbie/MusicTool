using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusikTool;

namespace MusikTool.Basisklassen
{
	/// <summary> Klasse       : bcl_gen_Liste<T>
	/// <para>generische Liste für alle Zwecke</para>
	/// <para>das Typparameter ist der Datentyp der Listenelemente</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>

	public class bcl_gen_Liste <T>
	{
		#region VersionInfo

		private static string zz_klassenName= "bcl_gen_Liste<T>";
		private static string zz_namespace = "MusikTool.Basisklassen";
		private static dataType zz_datenTyp = dataType.genListe;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "2";
		private static string zz_letzteBearbeitung= "2016-06-26  21:27:39";
		private static string zz_ersteBearbeitung= "2016-06-26 17:22.21";
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

		/// <summary>Liste der Elemente
		/// <para> TYP: Liste von T</para>
		/// </summary>
		private List<T> _liste;

		/// <summary>Name der Datensammlung
		/// <para>TYP: STRING</para>
		/// </summary>
		private string _name;

		/// <summary>ID der Liste
		/// <para>-1 ==> Index wird nicht gebraucht</para>
		/// <para>TYP: INT</para>
		/// </summary>
		private int _id;

		#endregion Attribute

		#region Konstruktor

		/// <summary> Konstruktor(name,id,PARAMS parameter)
		/// <para>initialisiert die Instanz mit allen Daten</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 2
		/// <para>    letzteBearbeitung: 2016-06-26  21:27:02</para>
		/// <para>    ersteBearbeitung : 2016-06-26  17:34:12</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="name">Name der Liste, TYP: STRING</param>
		/// <param name="id">ID der Liste, -1 heißt das der Wert irrelevant ist, TYP: INT</param>
		/// <param name="parameter">alle Listeneintrage , TYP: T[]</param>
		public bcl_gen_Liste(string name,int id,params T[] parameter )
		{
			_name = name;

			for( int i = 0 ; i < parameter.Length ; i++ ) {
				_liste.Add( parameter[i] );
			}
		}

		#endregion Konstruktor

		#region Eigenschaften

		/// <summary> Eigenschaft: Anzahl
		/// <para>gibt die Anzahl der gespeicherten Datensätze aus</para>
		/// <para>TYP: INT</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-06-26  17:37:10</para>
		/// <para>    ersteBearbeitung : 2016-06-26  17:37:10</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public int Anzahl { get { return _liste.Count; } }

		/// <summary> Eigenschaft: Name
		/// <para>gibt den Namen der Datensammlung aus</para>
		/// <para></para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-06-26  17:38:26</para>
		/// <para>    ersteBearbeitung : 2016-06-26  17:38:26</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public string Name { get { return _name; } }

		/// <summary> Eigenschaft: ID
		/// <para>gibt die ID aus, -1 bedeutet, daß die ID irrelevant ist</para>
		/// <para>TYP: INT</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-06-26  21:25:36</para>
		/// <para>    ersteBearbeitung : 2016-06-26  21:25:36</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public int ID { get { return _id; } }

		#endregion Eigenschaften

		#region Methoden

		/// <summary> Methode: get(id)
		/// <para>gibt ein Listenelement aus</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-06-26  17:43:25</para>
		/// <para>    ersteBearbeitung : 2016-06-26  17:43:25</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="id">ID des Listenelements, TYP: INT</param>
		/// <returns>Listenelement</returns>
		public T get(int id )
		{
			if( id > -1 | id < Anzahl ) return _liste[id];
			return default(T);
		}

		#endregion Methoden
	}
}
