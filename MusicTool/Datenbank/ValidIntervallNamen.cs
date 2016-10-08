using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusicTool;
using MusicTool.Basisklassen;

namespace MusicTool.Datenbank
{
	/// <summary> Klasse       : ValidIntervallNamen
	/// <para>STATISCHE KLASSE</para>
	/// <para>stellt fest, ob ein Intervallname gültig ist</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	public static class ValidIntervallNamen
	{
		#region VersionInfo

		private static string zz_klassenName= "ValidIntervallNamen";
		private static string zz_namespace = "MusicTool.Datenbank";
		private static dType zz_datenTyp = dType.Tool;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "1";
		private static string zz_letzteBearbeitung= "2016-07-10  16:44:17";
		private static string zz_ersteBearbeitung= "2016-07-10 16:29.56";
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

		/// <summary>Liste der Intervallnamen
		/// <para> TYP: Liste von STRING</para>
		/// </summary>
		private static List<string> _liste;

		#endregion Attribute

		#region Konstruktor

		/// <summary> STATISCHER Konstruktor()
		/// <para></para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  16:36:44</para>
		/// <para>    ersteBearbeitung : 2016-07-10  16:36:44</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		static ValidIntervallNamen()
		{
			_liste = new List<string>();
			Init();
		}

		/// <summary> Methode: Init()
		/// <para>initialisiert die Klasse mit allen Intervallnamen</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  16:43:21</para>
		/// <para>    ersteBearbeitung : 2016-07-10  16:43:21</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		private static void Init()
		{

			_liste.Add( "I" );
			_liste.Add( "b9" );
			_liste.Add( "9" );
			_liste.Add( "#9" );
			_liste.Add( "m" );
			_liste.Add( "III" );
			_liste.Add( "b11" );
			_liste.Add( "11" );
			_liste.Add( "#11" );
			_liste.Add( "b5" );
			_liste.Add( "V" );
			_liste.Add( "#5" );
			_liste.Add( "b13" );
			_liste.Add( "13" );
			_liste.Add( "b7" );
			_liste.Add( "7" );
			_liste.Add( "MAJ" );
		}

		#endregion Konstruktor

		#region Eigenschaften

		/// <summary> Eigenschaft: Anzahl
		/// <para>gibt die Anzahl der gespeicherten Intervallnamen aus</para>
		/// <para>TYP: INT</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  16:35:35</para>
		/// <para>    ersteBearbeitung : 2016-07-10  16:35:35</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static int Anzahl { get { return _liste.Count; } }

		#endregion Eigenschaften

		#region Methoden

		/// <summary> Methode: isValid(name)
		/// <para>stellt fest,ob der angegebene Name ein gültiger Intervallname ist</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  14:35:17</para>
		/// <para>    ersteBearbeitung : 2016-07-10  14:30:57</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static bool isValid( string name )
		{
			for( int i = 0 ; i < Anzahl ; i++ ) {
				if( _liste[i] == name ) return true;
			}

			return false;
		}

		/// <summary> Methode: getName(_index)
		/// <para>gibt einen Namen aus</para>
		/// <para>wenn der Index UNGÜLTIG ist, wird LEERSTRING ausgegeben</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  14:52:39</para>
		/// <para>    ersteBearbeitung : 2016-07-10  14:48:27</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="_index">Index des Intervallnamens, TYP: INT</param>
		/// <returns>Name des Intervalls, TYP: STRING</returns>
		public static string getName( int _index )
		{
			string tmp = "";

			try {
				tmp = _liste[_index];
			}
			catch( ArgumentOutOfRangeException ) {
				return "";
			}

			return tmp;
		}

		/// <summary> Methode: getName(Ton-Index)
		/// <para>gibt einen Intervallnamen aus</para>
		/// <para>wenn der Index UNGÜLTIG ist, wird LEERSTRING ausgegeben</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  15:10:29</para>
		/// <para>    ersteBearbeitung : 2016-07-10  15:10:29</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="ti">Index des Intervallnamens, TYP: eIntervall</param>
		/// <returns>Name des Tons, TYP: STRING</returns>
		public static string getName( eIntervall ti )
		{
			if( ti == eIntervall.X ) return "";

			return getName( (int)ti );
		}

		/// <summary> Methode: getIntervallObj(ti)
		/// <para>gibt ein Intervall-Objekt aus</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  19:47:39</para>
		/// <para>    ersteBearbeitung : 2016-07-10  19:47:39</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="ti">Index des Tons, TYP: eIntervall</param>
		/// <returns>Ton-Objekt, TYP: ds_Ton</returns>
		public static ds_Ton getIntervallObj(eIntervall ti )
		{
			ds_Ton tmp = null;
			string tmpName = "";

			tmpName = getName( ti );

			switch( tmpName ) {
				case "I":

					break;
			}

			return tmp;
		}

		#endregion Methoden
	}
}
