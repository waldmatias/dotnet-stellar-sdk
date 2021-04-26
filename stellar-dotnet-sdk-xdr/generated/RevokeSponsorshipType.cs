// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================

    //  enum RevokeSponsorshipType
    //  {
    //      REVOKE_SPONSORSHIP_LEDGER_ENTRY = 0,
    //      REVOKE_SPONSORSHIP_SIGNER = 1
    //  };

    //  ===========================================================================
    public class RevokeSponsorshipType
    {
        public enum RevokeSponsorshipTypeEnum
        {
            REVOKE_SPONSORSHIP_LEDGER_ENTRY = 0,
            REVOKE_SPONSORSHIP_SIGNER = 1,
        }
        public RevokeSponsorshipTypeEnum InnerValue { get; set; } = default(RevokeSponsorshipTypeEnum);

        public static RevokeSponsorshipType Create(RevokeSponsorshipTypeEnum v)
        {
            return new RevokeSponsorshipType
            {
                InnerValue = v
            };
        }

        public static RevokeSponsorshipType Decode(XdrDataInputStream stream)
        {
            int value = stream.ReadInt();
            switch (value)
            {
                case 0: return Create(RevokeSponsorshipTypeEnum.REVOKE_SPONSORSHIP_LEDGER_ENTRY);
                case 1: return Create(RevokeSponsorshipTypeEnum.REVOKE_SPONSORSHIP_SIGNER);
                default:
                    throw new Exception("Unknown enum value: " + value);
            }
        }

        public static void Encode(XdrDataOutputStream stream, RevokeSponsorshipType value)
        {
            stream.WriteInt((int)value.InnerValue);
        }
    }
}
