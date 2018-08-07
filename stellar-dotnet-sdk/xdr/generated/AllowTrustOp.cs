// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================

    //  struct AllowTrustOp
    //  {
    //      AccountID trustor;
    //      union switch (AssetType type)
    //      {
    //      // ASSET_TYPE_NATIVE is not allowed
    //      case ASSET_TYPE_CREDIT_ALPHANUM4:
    //          opaque assetCode4[4];
    //  
    //      case ASSET_TYPE_CREDIT_ALPHANUM12:
    //          opaque assetCode12[12];
    //  
    //          // add other asset types here in the future
    //      }
    //      asset;
    //  
    //      bool authorize;
    //  };

    //  ===========================================================================
    public class AllowTrustOp
    {
        public AllowTrustOp() { }
        public AccountID Trustor { get; set; }
        public AllowTrustOpAsset Asset { get; set; }
        public bool Authorize { get; set; }

        public static void Encode(XdrDataOutputStream stream, AllowTrustOp encodedAllowTrustOp)
        {
            AccountID.Encode(stream, encodedAllowTrustOp.Trustor);
            AllowTrustOpAsset.Encode(stream, encodedAllowTrustOp.Asset);
            stream.WriteInt(encodedAllowTrustOp.Authorize ? 1 : 0);
        }
        public static AllowTrustOp Decode(XdrDataInputStream stream)
        {
            AllowTrustOp decodedAllowTrustOp = new AllowTrustOp();
            decodedAllowTrustOp.Trustor = AccountID.Decode(stream);
            decodedAllowTrustOp.Asset = AllowTrustOpAsset.Decode(stream);
            decodedAllowTrustOp.Authorize = stream.ReadInt() == 1 ? true : false;
            return decodedAllowTrustOp;
        }

        public class AllowTrustOpAsset
        {
            public AllowTrustOpAsset() { }

            public AssetType Discriminant { get; set; } = new AssetType();

            public byte[] AssetCode4 { get; set; }
            public byte[] AssetCode12 { get; set; }
            public static void Encode(XdrDataOutputStream stream, AllowTrustOpAsset encodedAllowTrustOpAsset)
            {
                stream.WriteInt((int)encodedAllowTrustOpAsset.Discriminant.InnerValue);
                switch (encodedAllowTrustOpAsset.Discriminant.InnerValue)
                {
                    case AssetType.AssetTypeEnum.ASSET_TYPE_CREDIT_ALPHANUM4:
                        int assetCode4size = encodedAllowTrustOpAsset.AssetCode4.Length;
                        stream.Write(encodedAllowTrustOpAsset.AssetCode4, 0, assetCode4size);
                        break;
                    case AssetType.AssetTypeEnum.ASSET_TYPE_CREDIT_ALPHANUM12:
                        int assetCode12size = encodedAllowTrustOpAsset.AssetCode12.Length;
                        stream.Write(encodedAllowTrustOpAsset.AssetCode12, 0, assetCode12size);
                        break;
                }
            }
            public static AllowTrustOpAsset Decode(XdrDataInputStream stream)
            {
                AllowTrustOpAsset decodedAllowTrustOpAsset = new AllowTrustOpAsset();
                AssetType discriminant = AssetType.Decode(stream);
                decodedAllowTrustOpAsset.Discriminant = discriminant;
                switch (decodedAllowTrustOpAsset.Discriminant.InnerValue)
                {
                    case AssetType.AssetTypeEnum.ASSET_TYPE_CREDIT_ALPHANUM4:
                        int assetCode4size = 4;
                        decodedAllowTrustOpAsset.AssetCode4 = new byte[assetCode4size];
                        stream.Read(decodedAllowTrustOpAsset.AssetCode4, 0, assetCode4size);
                        break;
                    case AssetType.AssetTypeEnum.ASSET_TYPE_CREDIT_ALPHANUM12:
                        int assetCode12size = 12;
                        decodedAllowTrustOpAsset.AssetCode12 = new byte[assetCode12size];
                        stream.Read(decodedAllowTrustOpAsset.AssetCode12, 0, assetCode12size);
                        break;
                }
                return decodedAllowTrustOpAsset;
            }

        }
    }
}
