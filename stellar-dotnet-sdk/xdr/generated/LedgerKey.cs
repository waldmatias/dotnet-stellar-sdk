// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================

    //  union LedgerKey switch (LedgerEntryType type)
    //  {
    //  case ACCOUNT:
    //      struct
    //      {
    //          AccountID accountID;
    //      } account;
    //  
    //  case TRUSTLINE:
    //      struct
    //      {
    //          AccountID accountID;
    //          Asset asset;
    //      } trustLine;
    //  
    //  case OFFER:
    //      struct
    //      {
    //          AccountID sellerID;
    //          uint64 offerID;
    //      } offer;
    //  
    //  case DATA:
    //      struct
    //      {
    //          AccountID accountID;
    //          string64 dataName;
    //      } data;
    //  };

    //  ===========================================================================
    public class LedgerKey
    {
        public LedgerKey() { }

        public LedgerEntryType Discriminant { get; set; } = new LedgerEntryType();

        public LedgerKeyAccount Account { get; set; }
        public LedgerKeyTrustLine TrustLine { get; set; }
        public LedgerKeyOffer Offer { get; set; }
        public LedgerKeyData Data { get; set; }
        public static void Encode(XdrDataOutputStream stream, LedgerKey encodedLedgerKey)
        {
            stream.WriteInt((int)encodedLedgerKey.Discriminant.InnerValue);
            switch (encodedLedgerKey.Discriminant.InnerValue)
            {
                case LedgerEntryType.LedgerEntryTypeEnum.ACCOUNT:
                    LedgerKeyAccount.Encode(stream, encodedLedgerKey.Account);
                    break;
                case LedgerEntryType.LedgerEntryTypeEnum.TRUSTLINE:
                    LedgerKeyTrustLine.Encode(stream, encodedLedgerKey.TrustLine);
                    break;
                case LedgerEntryType.LedgerEntryTypeEnum.OFFER:
                    LedgerKeyOffer.Encode(stream, encodedLedgerKey.Offer);
                    break;
                case LedgerEntryType.LedgerEntryTypeEnum.DATA:
                    LedgerKeyData.Encode(stream, encodedLedgerKey.Data);
                    break;
            }
        }
        public static LedgerKey Decode(XdrDataInputStream stream)
        {
            LedgerKey decodedLedgerKey = new LedgerKey();
            LedgerEntryType discriminant = LedgerEntryType.Decode(stream);
            decodedLedgerKey.Discriminant = discriminant;
            switch (decodedLedgerKey.Discriminant.InnerValue)
            {
                case LedgerEntryType.LedgerEntryTypeEnum.ACCOUNT:
                    decodedLedgerKey.Account = LedgerKeyAccount.Decode(stream);
                    break;
                case LedgerEntryType.LedgerEntryTypeEnum.TRUSTLINE:
                    decodedLedgerKey.TrustLine = LedgerKeyTrustLine.Decode(stream);
                    break;
                case LedgerEntryType.LedgerEntryTypeEnum.OFFER:
                    decodedLedgerKey.Offer = LedgerKeyOffer.Decode(stream);
                    break;
                case LedgerEntryType.LedgerEntryTypeEnum.DATA:
                    decodedLedgerKey.Data = LedgerKeyData.Decode(stream);
                    break;
            }
            return decodedLedgerKey;
        }

        public class LedgerKeyAccount
        {
            public LedgerKeyAccount() { }
            public AccountID AccountID { get; set; }

            public static void Encode(XdrDataOutputStream stream, LedgerKeyAccount encodedLedgerKeyAccount)
            {
                AccountID.Encode(stream, encodedLedgerKeyAccount.AccountID);
            }
            public static LedgerKeyAccount Decode(XdrDataInputStream stream)
            {
                LedgerKeyAccount decodedLedgerKeyAccount = new LedgerKeyAccount();
                decodedLedgerKeyAccount.AccountID = AccountID.Decode(stream);
                return decodedLedgerKeyAccount;
            }

        }
        public class LedgerKeyTrustLine
        {
            public LedgerKeyTrustLine() { }
            public AccountID AccountID { get; set; }
            public Asset Asset { get; set; }

            public static void Encode(XdrDataOutputStream stream, LedgerKeyTrustLine encodedLedgerKeyTrustLine)
            {
                AccountID.Encode(stream, encodedLedgerKeyTrustLine.AccountID);
                Asset.Encode(stream, encodedLedgerKeyTrustLine.Asset);
            }
            public static LedgerKeyTrustLine Decode(XdrDataInputStream stream)
            {
                LedgerKeyTrustLine decodedLedgerKeyTrustLine = new LedgerKeyTrustLine();
                decodedLedgerKeyTrustLine.AccountID = AccountID.Decode(stream);
                decodedLedgerKeyTrustLine.Asset = Asset.Decode(stream);
                return decodedLedgerKeyTrustLine;
            }

        }
        public class LedgerKeyOffer
        {
            public LedgerKeyOffer() { }
            public AccountID SellerID { get; set; }
            public Uint64 OfferID { get; set; }

            public static void Encode(XdrDataOutputStream stream, LedgerKeyOffer encodedLedgerKeyOffer)
            {
                AccountID.Encode(stream, encodedLedgerKeyOffer.SellerID);
                Uint64.Encode(stream, encodedLedgerKeyOffer.OfferID);
            }
            public static LedgerKeyOffer Decode(XdrDataInputStream stream)
            {
                LedgerKeyOffer decodedLedgerKeyOffer = new LedgerKeyOffer();
                decodedLedgerKeyOffer.SellerID = AccountID.Decode(stream);
                decodedLedgerKeyOffer.OfferID = Uint64.Decode(stream);
                return decodedLedgerKeyOffer;
            }

        }
        public class LedgerKeyData
        {
            public LedgerKeyData() { }
            public AccountID AccountID { get; set; }
            public String64 DataName { get; set; }

            public static void Encode(XdrDataOutputStream stream, LedgerKeyData encodedLedgerKeyData)
            {
                AccountID.Encode(stream, encodedLedgerKeyData.AccountID);
                String64.Encode(stream, encodedLedgerKeyData.DataName);
            }
            public static LedgerKeyData Decode(XdrDataInputStream stream)
            {
                LedgerKeyData decodedLedgerKeyData = new LedgerKeyData();
                decodedLedgerKeyData.AccountID = AccountID.Decode(stream);
                decodedLedgerKeyData.DataName = String64.Decode(stream);
                return decodedLedgerKeyData;
            }

        }
    }
}
