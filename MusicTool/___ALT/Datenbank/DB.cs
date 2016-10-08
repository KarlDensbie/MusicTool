using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusikTool;
using MusikTool.Basisklassen;

namespace MusikTool.Datenbank
{
	/// <summary> Klasse       : DB
	/// <para>STATISCHE KLASSE</para>
	/// <para>Datenbank mit allen Daten über Töne, Intervalle,
	/// Tonarten, Akkorde und Modi</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>

	public static class DB
	{
		#region VersionInfo

		private static string zz_klassenName= "DB";
		private static string zz_namespace = "MusikTool.Datenbank";
		private static dataType zz_datenTyp = dataType.Datenbank;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "1";
		private static string zz_letzteBearbeitung= "2016-06-26  23:19:10";
		private static string zz_ersteBearbeitung= "2016-06-26 17:50.37";
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

		/// <summary>Datenbank der Töne
		/// <para> TYP: db_Töne</para>
		/// </summary>
		private static db_Töne _db_Töne;

		/// <summary>Datenbank der Intervalle
		/// <para> TYP: db_Intervalle</para>
		/// </summary>
		private static db_Intervalle _db_Intervalle;

		/// <summary>Datenbank der Tonarten
		/// <para> TYP: db_Tonarten</para>
		/// </summary>
		private static db_Tonarten _db_Tonarten;

		#endregion Attribute

		#region Konstruktor

		/// <summary>  Standardkonstruktor()
		/// <para>initialisiert die Datenbank</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-06-26  23:18:52</para>
		/// <para>    ersteBearbeitung : 2016-06-26  17:57:00</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		static DB()
		{
			Init_TonDB();
			Init_IntervallDB();
			Init_Tonarten();
		}
		#region INIT

		/// <summary> Methode: Init_TonDB()
		/// <para>initialisiert die Datenbank Töne</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 2
		/// <para>    letzteBearbeitung: 2016-06-26  19:01:28</para>
		/// <para>    ersteBearbeitung : 2016-06-26  18:28:48</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		private static void Init_TonDB()
		{
			_db_Töne = new db_Töne(
				new bcl_Ton( "Cbb" , eTon.Ceses ) ,
				new bcl_Ton( "Cb" , eTon.Ces ) ,
				new bcl_Ton( "C" , eTon.C ) ,
				new bcl_Ton( "C#" , eTon.Cis ) ,
				new bcl_Ton( "C##" , eTon.Cisis ) ,
				new bcl_Ton( "Dbb" , eTon.Deses ) ,
				new bcl_Ton( "Db" , eTon.Des ) ,
				new bcl_Ton( "D" , eTon.D ) ,
				new bcl_Ton( "D#" , eTon.Dis ) ,
				new bcl_Ton( "D##" , eTon.Disis ) ,
				new bcl_Ton( "Ebb" , eTon.Eses ) ,
				new bcl_Ton( "Eb" , eTon.Es ) ,
				new bcl_Ton( "E" , eTon.E ) ,
				new bcl_Ton( "E#" , eTon.Eis ) ,
				new bcl_Ton( "E##" , eTon.Eisis ) ,
				new bcl_Ton( "Fbb" , eTon.Feses ) ,
				new bcl_Ton( "Fb" , eTon.Fes ) ,
				new bcl_Ton( "F" , eTon.F ) ,
				new bcl_Ton( "F#" , eTon.Fis ) ,
				new bcl_Ton( "F##" , eTon.Fisis ) ,
				new bcl_Ton( "Gbb" , eTon.Geses ) ,
				new bcl_Ton( "Gb" , eTon.Ges ) ,
				new bcl_Ton( "G" , eTon.G ) ,
				new bcl_Ton( "G#" , eTon.Gis ) ,
				new bcl_Ton( "G##" , eTon.Gisis ) ,
				new bcl_Ton( "Abb" , eTon.Ases ) ,
				new bcl_Ton( "Ab" , eTon.As ) ,
				new bcl_Ton( "A" , eTon.A ) ,
				new bcl_Ton( "A#" , eTon.Ais ) ,
				new bcl_Ton( "A##" , eTon.Aisis ) ,
				new bcl_Ton( "Hbb" , eTon.Heses ) ,
				new bcl_Ton( "B" , eTon.B ) ,
				new bcl_Ton( "H" , eTon.H ) ,
				new bcl_Ton( "H#" , eTon.His ) ,
				new bcl_Ton( "H##" , eTon.Hisis )
				);
		}

		/// <summary> Methode: Init_IntervallDB()
		/// <para>initialisiert die Datenbank Intervalle</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-06-26  19:25:07</para>
		/// <para>    ersteBearbeitung : 2016-06-26  19:25:07</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		private static void Init_IntervallDB()
		{
			_db_Intervalle = new db_Intervalle(
				new bcl_Intervall( "I" , eIntervall.Prime ) ,
				new bcl_Intervall( "b9" , eIntervall.None_K ) ,
				new bcl_Intervall( "9" , eIntervall.None_G ) ,
				new bcl_Intervall( "#9" , eIntervall.None_Ü ) ,
				new bcl_Intervall( "m" , eIntervall.Terz_K ) ,
				new bcl_Intervall( "III" , eIntervall.Terz_G ) ,
				new bcl_Intervall( "b11" , eIntervall.Undez_V ) ,
				new bcl_Intervall( "11" , eIntervall.Undez ) ,
				new bcl_Intervall( "#11" , eIntervall.Undez_Ü ) ,
				new bcl_Intervall( "b5" , eIntervall.Quinte_V ) ,
				new bcl_Intervall( "V" , eIntervall.Quinte ) ,
				new bcl_Intervall( "#5" , eIntervall.Quinte_Ü ) ,
				new bcl_Intervall( "b13" , eIntervall.Tredez_K ) ,
				new bcl_Intervall( "13" , eIntervall.Tredez_G ) ,
				new bcl_Intervall( "b7" , eIntervall.Sept_V ) ,
				new bcl_Intervall( "7" , eIntervall.Sept_K ) ,
				new bcl_Intervall( "MAJ" , eIntervall.Sept_G )
				);
		}

		/// <summary> Methode: Init_Tonarten()
		/// <para>initialisiert die Datenbank Tonarten</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-06-26  23:17:26</para>
		/// <para>    ersteBearbeitung : 2016-06-26  23:17:26</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		private static void Init_Tonarten()
		{
			_db_Tonarten = new db_Tonarten( "" , -1 ,
			#region C
			new bcl_Tonart( "C" , (int)eTonart.C , _db_Töne.get( eTon.C ) ,
				_db_Töne.get( eTon.Des ) , _db_Töne.get( eTon.D ) , _db_Töne.get( eTon.Dis ) ,
				_db_Töne.get( eTon.Es ) , _db_Töne.get( eTon.E ) ,
				_db_Töne.get( eTon.Fes ) , _db_Töne.get( eTon.F ) , _db_Töne.get( eTon.Fis ) ,
				_db_Töne.get( eTon.Ges ) , _db_Töne.get( eTon.G ) , _db_Töne.get( eTon.Gis ) ,
				_db_Töne.get( eTon.As ) , _db_Töne.get( eTon.A ) ,
				_db_Töne.get( eTon.Heses ) , _db_Töne.get( eTon.B ) , _db_Töne.get( eTon.H )
				) ,
			new bcl_Tonart( "C#" , (int)eTonart.Cis , _db_Töne.get( eTon.Cis ) ,
				_db_Töne.get( eTon.D ) , _db_Töne.get( eTon.Dis ) , _db_Töne.get( eTon.Disis ) ,
				_db_Töne.get( eTon.E ) , _db_Töne.get( eTon.Eis ) ,
				_db_Töne.get( eTon.F ) , _db_Töne.get( eTon.Fis ) , _db_Töne.get( eTon.Fisis ) ,
				_db_Töne.get( eTon.G ) , _db_Töne.get( eTon.Gis ) , _db_Töne.get( eTon.Gisis ) ,
				_db_Töne.get( eTon.A ) , _db_Töne.get( eTon.Ais ) ,
				_db_Töne.get( eTon.B ) , _db_Töne.get( eTon.H ) , _db_Töne.get( eTon.His )
				) ,
			#endregion C
			#region D
			new bcl_Tonart( "Db" , (int)eTonart.Des , _db_Töne.get( eTon.Des ) ,
				_db_Töne.get( eTon.Eses ) , _db_Töne.get( eTon.Es ) , _db_Töne.get( eTon.E ) ,
				_db_Töne.get( eTon.Fes ) , _db_Töne.get( eTon.F ) ,
				_db_Töne.get( eTon.Geses ) , _db_Töne.get( eTon.Ges ) , _db_Töne.get( eTon.G ) ,
				_db_Töne.get( eTon.Ases ) , _db_Töne.get( eTon.As ) , _db_Töne.get( eTon.A ) ,
				_db_Töne.get( eTon.Heses ) , _db_Töne.get( eTon.B ) ,
				_db_Töne.get( eTon.Ceses ) , _db_Töne.get( eTon.Ces ) , _db_Töne.get( eTon.C )
				) ,
			new bcl_Tonart( "D" , (int)eTonart.D , _db_Töne.get( eTon.D ) ,
				_db_Töne.get( eTon.Es ) , _db_Töne.get( eTon.E ) , _db_Töne.get( eTon.Eis ) ,
				_db_Töne.get( eTon.F ) , _db_Töne.get( eTon.Fis ) ,
				_db_Töne.get( eTon.Ges ) , _db_Töne.get( eTon.G ) , _db_Töne.get( eTon.Gis ) ,
				_db_Töne.get( eTon.As ) , _db_Töne.get( eTon.A ) , _db_Töne.get( eTon.Ais ) ,
				_db_Töne.get( eTon.B ) , _db_Töne.get( eTon.H ) ,
				_db_Töne.get( eTon.Ces ) , _db_Töne.get( eTon.C ) , _db_Töne.get( eTon.Cis )
				) ,
			new bcl_Tonart( "D#" , (int)eTonart.Dis , _db_Töne.get( eTon.Dis ) ,
				_db_Töne.get( eTon.E ) , _db_Töne.get( eTon.Eis ) , _db_Töne.get( eTon.Eisis ) ,
				_db_Töne.get( eTon.Fis ) , _db_Töne.get( eTon.Fisis ) ,
				_db_Töne.get( eTon.G ) , _db_Töne.get( eTon.Gis ) , _db_Töne.get( eTon.Gisis ) ,
				_db_Töne.get( eTon.A ) , _db_Töne.get( eTon.Ais ) , _db_Töne.get( eTon.Aisis ) ,
				_db_Töne.get( eTon.H ) , _db_Töne.get( eTon.His ) ,
				_db_Töne.get( eTon.C ) , _db_Töne.get( eTon.Cis ) , _db_Töne.get( eTon.Cisis )
				) ,
			#endregion D
			#region E
			new bcl_Tonart( "Eb" , (int)eTonart.Es , _db_Töne.get( eTon.Es ) ,
				_db_Töne.get( eTon.Fes ) , _db_Töne.get( eTon.F ) , _db_Töne.get( eTon.Fis ) ,
				_db_Töne.get( eTon.Ges ) , _db_Töne.get( eTon.G ) ,
				_db_Töne.get( eTon.Ases ) , _db_Töne.get( eTon.As ) , _db_Töne.get( eTon.A ) ,
				_db_Töne.get( eTon.Heses ) , _db_Töne.get( eTon.B ) , _db_Töne.get( eTon.H ) ,
				_db_Töne.get( eTon.Ces ) , _db_Töne.get( eTon.C ) ,
				_db_Töne.get( eTon.Deses ) , _db_Töne.get( eTon.Des ) , _db_Töne.get( eTon.D )
				) ,
			new bcl_Tonart( "E" , (int)eTonart.E , _db_Töne.get( eTon.E ) ,
				_db_Töne.get( eTon.F ) , _db_Töne.get( eTon.Fis ) , _db_Töne.get( eTon.Fisis ) ,
				_db_Töne.get( eTon.G ) , _db_Töne.get( eTon.Gis ) ,
				_db_Töne.get( eTon.As ) , _db_Töne.get( eTon.A ) , _db_Töne.get( eTon.Ais ) ,
				_db_Töne.get( eTon.B ) , _db_Töne.get( eTon.H ) , _db_Töne.get( eTon.His ) ,
				_db_Töne.get( eTon.C ) , _db_Töne.get( eTon.Cis ) ,
				_db_Töne.get( eTon.Des ) , _db_Töne.get( eTon.D ) , _db_Töne.get( eTon.Dis )
				) ,
			#endregion E
			#region F
			new bcl_Tonart( "F" , (int)eTonart.F , _db_Töne.get( eTon.F ) ,
				_db_Töne.get( eTon.Ges ) , _db_Töne.get( eTon.G ) , _db_Töne.get( eTon.Gis ) ,
				_db_Töne.get( eTon.As ) , _db_Töne.get( eTon.A ) ,
				_db_Töne.get( eTon.Heses ) , _db_Töne.get( eTon.B ) , _db_Töne.get( eTon.H ) ,
				_db_Töne.get( eTon.Ces ) , _db_Töne.get( eTon.C ) , _db_Töne.get( eTon.Cis ) ,
				_db_Töne.get( eTon.Des ) , _db_Töne.get( eTon.D ) ,
				_db_Töne.get( eTon.Eses ) , _db_Töne.get( eTon.Es ) , _db_Töne.get( eTon.E )
				) ,
			new bcl_Tonart( "F#" , (int)eTonart.Fis , _db_Töne.get( eTon.Fis ) ,
				_db_Töne.get( eTon.G ) , _db_Töne.get( eTon.Gis ) , _db_Töne.get( eTon.Gisis ) ,
				_db_Töne.get( eTon.A ) , _db_Töne.get( eTon.Ais ) ,
				_db_Töne.get( eTon.B ) , _db_Töne.get( eTon.H ) , _db_Töne.get( eTon.His ) ,
				_db_Töne.get( eTon.C ) , _db_Töne.get( eTon.Cis ) , _db_Töne.get( eTon.Cisis ) ,
				_db_Töne.get( eTon.D ) , _db_Töne.get( eTon.Dis ) ,
				_db_Töne.get( eTon.Es ) , _db_Töne.get( eTon.E ) , _db_Töne.get( eTon.Eis )
				) ,
			#endregion F
			#region G
			new bcl_Tonart( "Gb" , (int)eTonart.Ges , _db_Töne.get( eTon.Ges ) ,
				_db_Töne.get( eTon.Ases ) , _db_Töne.get( eTon.As ) , _db_Töne.get( eTon.A ) ,
				_db_Töne.get( eTon.Heses ) , _db_Töne.get( eTon.B ) ,
				_db_Töne.get( eTon.Ceses ) , _db_Töne.get( eTon.Ces ) , _db_Töne.get( eTon.C ) ,
				_db_Töne.get( eTon.Deses ) , _db_Töne.get( eTon.Des ) , _db_Töne.get( eTon.D ) ,
				_db_Töne.get( eTon.Eses ) , _db_Töne.get( eTon.Es ) ,
				_db_Töne.get( eTon.Feses ) , _db_Töne.get( eTon.Fes ) , _db_Töne.get( eTon.F )
				) ,
			new bcl_Tonart( "G" , (int)eTonart.G , _db_Töne.get( eTon.G ) ,
				_db_Töne.get( eTon.As ) , _db_Töne.get( eTon.A ) , _db_Töne.get( eTon.Ais ) ,
				_db_Töne.get( eTon.B ) , _db_Töne.get( eTon.H ) ,
				_db_Töne.get( eTon.Ces ) , _db_Töne.get( eTon.C ) , _db_Töne.get( eTon.Cis ) ,
				_db_Töne.get( eTon.Des ) , _db_Töne.get( eTon.D ) , _db_Töne.get( eTon.Dis ) ,
				_db_Töne.get( eTon.Es ) , _db_Töne.get( eTon.E ) ,
				_db_Töne.get( eTon.Fes ) , _db_Töne.get( eTon.F ) , _db_Töne.get( eTon.Fis )
				) ,
			new bcl_Tonart( "G#" , (int)eTonart.Gis , _db_Töne.get( eTon.Gis ) ,
				_db_Töne.get( eTon.A ) , _db_Töne.get( eTon.Ais ) , _db_Töne.get( eTon.Aisis ) ,
				_db_Töne.get( eTon.H ) , _db_Töne.get( eTon.His ) ,
				_db_Töne.get( eTon.C ) , _db_Töne.get( eTon.Cis ) , _db_Töne.get( eTon.Cisis ) ,
				_db_Töne.get( eTon.D ) , _db_Töne.get( eTon.Dis ) , _db_Töne.get( eTon.Disis ) ,
				_db_Töne.get( eTon.E ) , _db_Töne.get( eTon.Eis ) ,
				_db_Töne.get( eTon.F ) , _db_Töne.get( eTon.Fis ) , _db_Töne.get( eTon.Fisis )
				) ,
			#endregion G
			#region A
			new bcl_Tonart( "Ab" , (int)eTonart.As , _db_Töne.get( eTon.As ) ,
				_db_Töne.get( eTon.Heses ) , _db_Töne.get( eTon.B ) , _db_Töne.get( eTon.H ) ,
				_db_Töne.get( eTon.Ces ) , _db_Töne.get( eTon.C ) ,
				_db_Töne.get( eTon.Deses ) , _db_Töne.get( eTon.Des ) , _db_Töne.get( eTon.D ) ,
				_db_Töne.get( eTon.Eses ) , _db_Töne.get( eTon.Es ) , _db_Töne.get( eTon.E ) ,
				_db_Töne.get( eTon.Fes ) , _db_Töne.get( eTon.F ) ,
				_db_Töne.get( eTon.Geses ) , _db_Töne.get( eTon.Ges ) , _db_Töne.get( eTon.G )
				) ,
			new bcl_Tonart( "A" , (int)eTonart.A , _db_Töne.get( eTon.A ) ,
				_db_Töne.get( eTon.B ) , _db_Töne.get( eTon.H ) , _db_Töne.get( eTon.His ) ,
				_db_Töne.get( eTon.C ) , _db_Töne.get( eTon.Cis ) ,
				_db_Töne.get( eTon.Des ) , _db_Töne.get( eTon.D ) , _db_Töne.get( eTon.Dis ) ,
				_db_Töne.get( eTon.Es ) , _db_Töne.get( eTon.E ) , _db_Töne.get( eTon.Eis ) ,
				_db_Töne.get( eTon.F ) , _db_Töne.get( eTon.Fis ) ,
				_db_Töne.get( eTon.Ges ) , _db_Töne.get( eTon.G ) , _db_Töne.get( eTon.Gis )
				) ,
			new bcl_Tonart( "A#" , (int)eTonart.Ais , _db_Töne.get( eTon.Ais ) ,
				_db_Töne.get( eTon.H ) , _db_Töne.get( eTon.His ) , _db_Töne.get( eTon.Hisis ) ,
				_db_Töne.get( eTon.Cis ) , _db_Töne.get( eTon.Cisis ) ,
				_db_Töne.get( eTon.D ) , _db_Töne.get( eTon.Dis ) , _db_Töne.get( eTon.Disis ) ,
				_db_Töne.get( eTon.E ) , _db_Töne.get( eTon.Eis ) , _db_Töne.get( eTon.Eisis ) ,
				_db_Töne.get( eTon.Fis ) , _db_Töne.get( eTon.Fisis ) ,
				_db_Töne.get( eTon.G ) , _db_Töne.get( eTon.Gis ) , _db_Töne.get( eTon.Gisis )
				) ,
			#endregion A
			#region H
			new bcl_Tonart( "B" , (int)eTonart.B , _db_Töne.get( eTon.B ) ,
				_db_Töne.get( eTon.Ces ) , _db_Töne.get( eTon.C ) , _db_Töne.get( eTon.Cis ) ,
				_db_Töne.get( eTon.Des ) , _db_Töne.get( eTon.D ) ,
				_db_Töne.get( eTon.Eses ) , _db_Töne.get( eTon.Es ) , _db_Töne.get( eTon.E ) ,
				_db_Töne.get( eTon.Fes ) , _db_Töne.get( eTon.F ) , _db_Töne.get( eTon.Fis ) ,
				_db_Töne.get( eTon.Ges ) , _db_Töne.get( eTon.G ) ,
				_db_Töne.get( eTon.Ases ) , _db_Töne.get( eTon.As ) , _db_Töne.get( eTon.A )
				) ,
			new bcl_Tonart( "H" , (int)eTonart.H , _db_Töne.get( eTon.H ) ,
				_db_Töne.get( eTon.C ) , _db_Töne.get( eTon.Cis ) , _db_Töne.get( eTon.Cisis ) ,
				_db_Töne.get( eTon.D ) , _db_Töne.get( eTon.Dis ) ,
				_db_Töne.get( eTon.Es ) , _db_Töne.get( eTon.E ) , _db_Töne.get( eTon.Eis ) ,
				_db_Töne.get( eTon.F ) , _db_Töne.get( eTon.Fis ) , _db_Töne.get( eTon.Fisis ) ,
				_db_Töne.get( eTon.G ) , _db_Töne.get( eTon.Gis ) ,
				_db_Töne.get( eTon.As ) , _db_Töne.get( eTon.A ) , _db_Töne.get( eTon.Ais )
				)
			#endregion H
			);
		}

		#endregion MyRegion

		#endregion Konstruktor

		#region Eigenschaften

		#endregion Eigenschaften

		#region Methoden

		#endregion Methoden
	}
}
