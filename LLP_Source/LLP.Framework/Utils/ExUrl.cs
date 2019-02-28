﻿using System;
using System.Collections;
using System.Web;

namespace LLP.Framework.Utils
{
	public class ExURL
	{
		public const string ENCRYPTED_PARAM = "microapps";
		public const string RETURN_URL = "RU7Of9";
		public const string RETURN_PARAM = "8472";
		public const string TIMESTAMP = "U0";

		public string Path;
		public Hashtable __Query;

		private Hashtable _Query
		{
			get
			{
				if( null == __Query )
					__Query = new Hashtable();
				return __Query;
			}
		}
		public string ReturnURL
		{
			get
			{
				return (string)_Query[ RETURN_URL ];
			}
			set
			{
				if( null == value )
					_Query.Remove( RETURN_URL );
				else
					_Query[ RETURN_URL ] = value;
			}
		}

		public string ReturnParam
		{
			get
			{
				return (string)_Query[ RETURN_PARAM ];
			}
			set
			{
				if( null == value )
					_Query.Remove( RETURN_PARAM );
				else
					_Query[ RETURN_PARAM ] = value;
			}
		}

		public ExURL( string fullURL )
		{
			if( fullURL.IndexOf("?") > 0 )
			{
				string [] parts = fullURL.Split('?');
				Path = parts[0].Trim();
				if( parts.Length > 1 )
					Parse( parts[1] );				
			}
			else
			{
				Path = fullURL;
			}
		}

		public ExURL( string path, string encryptedQuery ) : this( path )
		{
			Parse( encryptedQuery );			
		}

		public string this[ string paramName ]
		{
			get
			{
				return (string)_Query[ paramName ];
			}
			set
			{
				if( null == paramName )
					_Query.Remove( paramName );
				else
					_Query[ paramName ] = value;
			}
		}

		public void Parse( string queryString )
		{			
			int valuePos = queryString.IndexOf("=");

            if (valuePos < 0)
                //throw new University.Framework.Exceptions.UniversityException( "Invalid URL: " + queryString );
                throw new Exception();
					
			string name = queryString.Substring(0, valuePos);
			
			string val = queryString.Substring( valuePos + 1 );
			
			if( ENCRYPTED_PARAM == name )
			{
				// If the parameter has any useful value then proceed. a blank parameter can be supplied
				if( val.Length > 0 )
				{
					// convert the hex string to normal string
					//val = HexToString( val );
					
			
					// Decrypt the query string
					string decrypted = LLP.Framework.Utils.StringCrypto.Decrypt( val );
					
					// Find all name value pairs in the query string
					string [] pairs = decrypted.Split('&');

					// Populate hashtable with query parameters
					for( int j = 0; j < pairs.Length; j ++ )
					{
						string param = pairs[j];
						int equalPos = param.IndexOf('=');

						if( equalPos > 0 )
						{
							string paramName = param.Substring(0, equalPos );
							string paramVal = HttpUtility.UrlDecode( param.Substring( equalPos+1 ) );

							_Query.Add( paramName, paramVal );
						}
					}
				}
			}
			else
			{
				val = HttpUtility.UrlDecode( val );

				_Query.Add( name, val );
			}
						
		}
		
		~ExURL()
		{
			__Query = null;
		}

		public override string ToString()
		{
			return ToString( false );
		}
		public string ToString( bool doubleEncode )
		{
			// Build URL generation timestamp
			_Query[ TIMESTAMP ] = DateTime.Now.Ticks.ToString();
			
			string queryString = this.ToPlainString();
			// encrypt the entire string
			string encryptedQuery = LLP.Framework.Utils.StringCrypto.Encrypt( queryString );			
			
			// Build the actual URL with encrypted parameter and the encrypted value
			string encodedQuery = encryptedQuery; //StringToHex( encryptedQuery ); //HttpUtility.UrlEncode( encryptedQuery );
			
			return Path + "?" + ENCRYPTED_PARAM + "=" + encodedQuery;
		
		}		

		public string ToPlainString()
		{
			// Build the query string from query parameters
			System.Text.StringBuilder query = new System.Text.StringBuilder(_Query.Count*10);
			IDictionaryEnumerator e = _Query.GetEnumerator();

			// Build name-value pair for each parameter
			while( e.MoveNext() )
			{
				query.Append( (string)e.Key );
				query.Append('=');
				query.Append( HttpUtility.UrlEncode( (string)e.Value ) );
				query.Append( '&' );
			}

			return query.ToString();
		}
	}
}