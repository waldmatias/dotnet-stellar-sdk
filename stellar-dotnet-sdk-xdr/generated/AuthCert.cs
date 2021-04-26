// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================

    //  struct AuthCert
    //  {
    //      Curve25519Public pubkey;
    //      uint64 expiration;
    //      Signature sig;
    //  };

    //  ===========================================================================
    public class AuthCert
    {
        public AuthCert() { }
        public Curve25519Public Pubkey { get; set; }
        public Uint64 Expiration { get; set; }
        public Signature Sig { get; set; }

        public static void Encode(XdrDataOutputStream stream, AuthCert encodedAuthCert)
        {
            Curve25519Public.Encode(stream, encodedAuthCert.Pubkey);
            Uint64.Encode(stream, encodedAuthCert.Expiration);
            Signature.Encode(stream, encodedAuthCert.Sig);
        }
        public static AuthCert Decode(XdrDataInputStream stream)
        {
            AuthCert decodedAuthCert = new AuthCert();
            decodedAuthCert.Pubkey = Curve25519Public.Decode(stream);
            decodedAuthCert.Expiration = Uint64.Decode(stream);
            decodedAuthCert.Sig = Signature.Decode(stream);
            return decodedAuthCert;
        }
    }
}
