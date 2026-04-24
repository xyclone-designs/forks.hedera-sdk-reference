using Hedera.Hashgraph.Reference.Cryptography;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;
using static Grpc.Core.Metadata;
using static System.Net.Mime.MediaTypeNames;

namespace Hedera.Hashgraph.Reference.Cryptography
{
    /// <summary>
    /// Test vectors provided by the <a href="https://github.com/bitcoin/bips/blob/master/bip-0039.mediawiki">BIP39</a> standards.
    /// Test for proper mnemonic and seed derivation from a given entropy.
    /// The passphrase to be used for all these tests to generate the seed is "TREZOR".
    /// </summary>
    public static class TestVectors
    {
        #region BIP39 Mnemonics

        public static class Bip39
        {
            public record MnemonicTestVector(string Entropy, string Mnemonic, string Seed);

            public static readonly MnemonicTestVector Test1 = new(
                Entropy: "00000000000000000000000000000000",
                Mnemonic: "abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon about",
                Seed: "c55257c360c07c72029aebc1b53c05ed0362ada38ead3e3e9efa3708e53495531f09a6987599d18264c1e1c92f2cf141630c7a3c4ab7c81b2f001698e7463b04"
            );
            public static readonly MnemonicTestVector Test2 = new(
                Entropy: "7f7f7f7f7f7f7f7f7f7f7f7f7f7f7f7f",
                Mnemonic: "legal winner thank year wave sausage worth useful legal winner thank yellow",
                Seed: "2e8905819b8723fe2c1d161860e5ee1830318dbf49a83bd451cfb8440c28bd6fa457fe1296106559a3c80937a1c1069be3a3a5bd381ee6260e8d9739fce1f607"
            );
            public static readonly MnemonicTestVector Test3 = new(
                Entropy: "80808080808080808080808080808080",
                Mnemonic: "letter advice cage absurd amount doctor acoustic avoid letter advice cage above",
                Seed: "d71de856f81a8acc65e6fc851a38d4d7ec216fd0796d0a6827a3ad6ed5511a30fa280f12eb2e47ed2ac03b5c462a0358d18d69fe4f985ec81778c1b370b652a8"
            );
            public static readonly MnemonicTestVector Test4 = new(
                Entropy: "ffffffffffffffffffffffffffffffff",
                Mnemonic: "zoo zoo zoo zoo zoo zoo zoo zoo zoo zoo zoo wrong",
                Seed: "ac27495480225222079d7be181583751e86f571027b0497b5b5d11218e0a8a13332572917f0f8e5a589620c6f15b11c61dee327651a14c34e18231052e48c069"
            );
            public static readonly MnemonicTestVector Test5 = new(
                Entropy: "0000000000000000000000000000000000000000000000000000000000000000",
                Mnemonic: "abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon art",
                Seed: "bda85446c68413707090a52022edd26a1c9462295029f2e60cd7c4f2bbd3097170af7a4d73245cafa9c3cca8d561a7c3de6f5d4a10be8ed2a5e608d68f92fcc8"
            );
            public static readonly MnemonicTestVector Test6 = new(
                Entropy: "7f7f7f7f7f7f7f7f7f7f7f7f7f7f7f7f7f7f7f7f7f7f7f7f7f7f7f7f7f7f7f7f",
                Mnemonic: "legal winner thank year wave sausage worth useful legal winner thank year wave sausage worth useful legal winner thank year wave sausage worth title",
                Seed: "bc09fca1804f7e69da93c2f2028eb238c227f2e9dda30cd63699232578480a4021b146ad717fbb7e451ce9eb835f43620bf5c514db0f8add49f5d121449d3e87"
            );
            public static readonly MnemonicTestVector Test7 = new(
                Entropy: "8080808080808080808080808080808080808080808080808080808080808080",
                Mnemonic: "letter advice cage absurd amount doctor acoustic avoid letter advice cage absurd amount doctor acoustic avoid letter advice cage absurd amount doctor acoustic bless",
                Seed: "c0c519bd0e91a2ed54357d9d1ebef6f5af218a153624cf4f2da911a0ed8f7a09e2ef61af0aca007096df430022f7a2b6fb91661a9589097069720d015e4e982f"
            );
            public static readonly MnemonicTestVector Test8 = new(
                Entropy: "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
                Mnemonic: "zoo zoo zoo zoo zoo zoo zoo zoo zoo zoo zoo zoo zoo zoo zoo zoo zoo zoo zoo zoo zoo zoo zoo vote",
                Seed: "dd48c104698c30cfe2b6142103248622fb7bb0ff692eebb00089b32d22484e1613912f0a5b694407be899ffd31ed3992c456cdf60f5d4564b8ba3f05a69890ad"
            );
            public static readonly MnemonicTestVector Test9 = new(
                Entropy: "9e885d952ad362caeb4efe34a8e91bd2",
                Mnemonic: "ozone drill grab fiber curtain grace pudding thank cruise elder eight picnic",
                Seed: "274ddc525802f7c828d8ef7ddbcdc5304e87ac3535913611fbbfa986d0c9e5476c91689f9c8a54fd55bd38606aa6a8595ad213d4c9c9f9aca3fb217069a41028"
            );
            public static readonly MnemonicTestVector Test10 = new(
                Entropy: "68a79eaca2324873eacc50cb9c6eca8cc68ea5d936f98787c60c7ebc74e6ce7c",
                Mnemonic: "hamster diagram private dutch cause delay private meat slide toddler razor book happy fancy gospel tennis maple dilemma loan word shrug inflict delay length",
                Seed: "64c87cde7e12ecf6704ab95bb1408bef047c22db4cc7491c4271d170a1b213d20b385bc1588d9c7b38f1b39d415665b8a9030c9ec653d75e65f847d8fc1fc440"
            );
            public static readonly MnemonicTestVector Test11 = new(
                Entropy: "c0ba5a8e914111210f2bd131f3d5e08d",
                Mnemonic: "scheme spot photo card baby mountain device kick cradle pact join borrow",
                Seed: "ea725895aaae8d4c1cf682c1bfd2d358d52ed9f0f0591131b559e2724bb234fca05aa9c02c57407e04ee9dc3b454aa63fbff483a8b11de949624b9f1831a9612"
            );
            public static readonly MnemonicTestVector Test12 = new(
                Entropy: "9f6a2878b2520799a44ef18bc7df394e7061a224d2c33cd015b157d746869863",
                Mnemonic: "panda eyebrow bullet gorilla call smoke muffin taste mesh discover soft ostrich alcohol speed nation flash devote level hobby quick inner drive ghost inside",
                Seed: "72be8e052fc4919d2adf28d5306b5474b0069df35b02303de8c1729c9538dbb6fc2d731d5f832193cd9fb6aeecbc469594a70e3dd50811b5067f3b88b28c3e8d"
            );
            public static readonly MnemonicTestVector Test13 = new(
                Entropy: "23db8160a31d3e0dca3688ed941adbf3",
                Mnemonic: "cat swing flag economy stadium alone churn speed unique patch report train",
                Seed: "deb5f45449e615feff5640f2e49f933ff51895de3b4381832b3139941c57b59205a42480c52175b6efcffaa58a2503887c1e8b363a707256bdd2b587b46541f5"
            );
            public static readonly MnemonicTestVector Test14 = new(
                Entropy: "066dca1a2bb7e8a1db2832148ce9933eea0f3ac9548d793112d9a95c9407efad",
                Mnemonic: "all hour make first leader extend hole alien behind guard gospel lava path output census museum junior mass reopen famous sing advance salt reform",
                Seed: "26e975ec644423f4a4c4f4215ef09b4bd7ef924e85d1d17c4cf3f136c2863cf6df0a475045652c57eb5fb41513ca2a2d67722b77e954b4b3fc11f7590449191d"
            );
            public static readonly MnemonicTestVector Test15 = new(
                Entropy: "f30f8c1da665478f49b001d94c5fc452",
                Mnemonic: "vessel ladder alter error federal sibling chat ability sun glass valve picture",
                Seed: "2aaa9242daafcee6aa9d7269f17d4efe271e1b9a529178d7dc139cd18747090bf9d60295d0ce74309a78852a9caadf0af48aae1c6253839624076224374bc63f"
            );
            public static readonly MnemonicTestVector Test16 = new(
                Entropy: "f585c11aec520db57dd353c69554b21a89b20fb0650966fa0a9d6f74fd989d8f",
                Mnemonic: "void come effort suffer camp survey warrior heavy shoot primary clutch crush open amazing screen patrol group space point ten exist slush involve unfold",
                Seed: "01f5bced59dec48e362f2c45b5de68b9fd6c92c6634f44d6d40aab69056506f0e35524a518034ddc1192e1dacd32c1ed3eaa3c3b131c88ed8e7e54c49a5d0998"
            );
        }

        #endregion

        #region SLIP10 Key Derivation

        /// <summary>
        /// Test vectors provided by the <a href="https://github.com/satoshilabs/slips/blob/master/slip-0010.md">SLIP10</a> standards.
        /// Test for proper key derivation from a given hex seed and derivation chain.
        /// </summary>
        public static class Slip10
        {
            public record KeyDerivationTestVector(string DerivationChain, string ChainCode, string PrivateKeyBytes, string PublicKeyBytes);

            /// <summary>Derivation test vector 1 for ECDSAsecp256k1</summary>
            public static class EcdsaSecp256k1Vector1
            {
                public const string Seed = "000102030405060708090a0b0c0d0e0f";

                public static readonly KeyDerivationTestVector Test1 = new(
                    DerivationChain: "m/",
                    ChainCode: "873dff81c02f525623fd1fe5167eac3a55a049de3d314bb42ee227ffed37d508",
                    PrivateKeyBytes: "e8f32e723decf4051aefac8e2c93c9c5b214313817cdb01a1494b917c8436b35",
                    PublicKeyBytes: "0339a36013301597daef41fbe593a02cc513d0b55527ec2df1050e2e8ff49c85c2"
                );
                public static readonly KeyDerivationTestVector Test2 = new(
                    DerivationChain: "m/0'",
                    ChainCode: "47fdacbd0f1097043b78c63c20c34ef4ed9a111d980047ad16282c7ae6236141",
                    PrivateKeyBytes: "edb2e14f9ee77d26dd93b4ecede8d16ed408ce149b6cd80b0715a2d911a0afea",
                    PublicKeyBytes: "035a784662a4a20a65bf6aab9ae98a6c068a81c52e4b032c0fb5400c706cfccc56"
                );
                public static readonly KeyDerivationTestVector Test3 = new(
                    DerivationChain: "m/0'/1",
                    ChainCode: "2a7857631386ba23dacac34180dd1983734e444fdbf774041578e9b6adb37c19",
                    PrivateKeyBytes: "3c6cb8d0f6a264c91ea8b5030fadaa8e538b020f0a387421a12de9319dc93368",
                    PublicKeyBytes: "03501e454bf00751f24b1b489aa925215d66af2234e3891c3b21a52bedb3cd711c"
                );
                public static readonly KeyDerivationTestVector Test4 = new(
                    DerivationChain: "m/0'/1/2'",
                    ChainCode: "04466b9cc8e161e966409ca52986c584f07e9dc81f735db683c3ff6ec7b1503f",
                    PrivateKeyBytes: "cbce0d719ecf7431d88e6a89fa1483e02e35092af60c042b1df2ff59fa424dca",
                    PublicKeyBytes: "0357bfe1e341d01c69fe5654309956cbea516822fba8a601743a012a7896ee8dc2"
                );
                public static readonly KeyDerivationTestVector Test5 = new(
                    DerivationChain: "m/0'/1/2'/2",
                    ChainCode: "cfb71883f01676f587d023cc53a35bc7f88f724b1f8c2892ac1275ac822a3edd",
                    PrivateKeyBytes: "0f479245fb19a38a1954c5c7c0ebab2f9bdfd96a17563ef28a6a4b1a2a764ef4",
                    PublicKeyBytes: "02e8445082a72f29b75ca48748a914df60622a609cacfce8ed0e35804560741d29"
                );
                public static readonly KeyDerivationTestVector Test6 = new(
                    DerivationChain: "m/0'/1/2'/2/1000000000",
                    ChainCode: "c783e67b921d2beb8f6b389cc646d7263b4145701dadd2161548a8b078e65e9e",
                    PrivateKeyBytes: "471b76e389e528d6de6d816857e012c5455051cad6660850e58372a6c3e6e7c8",
                    PublicKeyBytes: "022a471424da5e657499d1ff51cb43c47481a03b1e77f951fe64cec9f5a48f7011"
                );
            }

            /// <summary>Derivation test vector 2 for ECDSAsecp256k1</summary>
            public static class EcdsaSecp256k1Vector2
            {
                public const string Seed = "fffcf9f6f3f0edeae7e4e1dedbd8d5d2cfccc9c6c3c0bdbab7b4b1aeaba8a5a29f9c999693908d8a8784817e7b7875726f6c696663605d5a5754514e4b484542";

                public static readonly KeyDerivationTestVector Test1 = new(
                    DerivationChain: "m/",
                    ChainCode: "60499f801b896d83179a4374aeb7822aaeaceaa0db1f85ee3e904c4defbd9689",
                    PrivateKeyBytes: "4b03d6fc340455b363f51020ad3ecca4f0850280cf436c70c727923f6db46c3e",
                    PublicKeyBytes: "03cbcaa9c98c877a26977d00825c956a238e8dddfbd322cce4f74b0b5bd6ace4a7"
                );
                public static readonly KeyDerivationTestVector Test2 = new(
                    DerivationChain: "m/0",
                    ChainCode: "f0909affaa7ee7abe5dd4e100598d4dc53cd709d5a5c2cac40e7412f232f7c9c",
                    PrivateKeyBytes: "abe74a98f6c7eabee0428f53798f0ab8aa1bd37873999041703c742f15ac7e1e",
                    PublicKeyBytes: "02fc9e5af0ac8d9b3cecfe2a888e2117ba3d089d8585886c9c826b6b22a98d12ea"
                );
                public static readonly KeyDerivationTestVector Test3 = new(
                    DerivationChain: "m/0/2147483647'",
                    ChainCode: "be17a268474a6bb9c61e1d720cf6215e2a88c5406c4aee7b38547f585c9a37d9",
                    PrivateKeyBytes: "877c779ad9687164e9c2f4f0f4ff0340814392330693ce95a58fe18fd52e6e93",
                    PublicKeyBytes: "03c01e7425647bdefa82b12d9bad5e3e6865bee0502694b94ca58b666abc0a5c3b"
                );
                public static readonly KeyDerivationTestVector Test4 = new(
                    DerivationChain: "m/0/2147483647'/1",
                    ChainCode: "f366f48f1ea9f2d1d3fe958c95ca84ea18e4c4ddb9366c336c927eb246fb38cb",
                    PrivateKeyBytes: "704addf544a06e5ee4bea37098463c23613da32020d604506da8c0518e1da4b7",
                    PublicKeyBytes: "03a7d1d856deb74c508e05031f9895dab54626251b3806e16b4bd12e781a7df5b9"
                );
                public static readonly KeyDerivationTestVector Test5 = new(
                    DerivationChain: "m/0/2147483647'/1/2147483646'",
                    ChainCode: "637807030d55d01f9a0cb3a7839515d796bd07706386a6eddf06cc29a65a0e29",
                    PrivateKeyBytes: "f1c7c871a54a804afe328b4c83a1c33b8e5ff48f5087273f04efa83b247d6a2d",
                    PublicKeyBytes: "02d2b36900396c9282fa14628566582f206a5dd0bcc8d5e892611806cafb0301f0"
                );
                public static readonly KeyDerivationTestVector Test6 = new(
                    DerivationChain: "m/0/2147483647'/1/2147483646'/2",
                    ChainCode: "9452b549be8cea3ecb7a84bec10dcfd94afe4d129ebfd3b3cb58eedf394ed271",
                    PrivateKeyBytes: "bb7d39bdb83ecf58f2fd82b6d918341cbef428661ef01ab97c28a4842125ac23",
                    PublicKeyBytes: "024d902e1a2fc7a8755ab5b694c575fce742c48d9ff192e63df5193e4c7afe1f9c"
                );
            }

            /// <summary>Derivation test vector 1 for ED25519</summary>
            public static class Ed25519Vector1
            {
                public const string Seed = "000102030405060708090a0b0c0d0e0f";

                public static readonly KeyDerivationTestVector Test1 = new(
                    DerivationChain: "m/",
                    ChainCode: "90046a93de5380a72b5e45010748567d5ea02bbf6522f979e05c0d8d8ca9fffb",
                    PrivateKeyBytes: "2b4be7f19ee27bbf30c667b642d5f4aa69fd169872f8fc3059c08ebae2eb19e7",
                    PublicKeyBytes: "00a4b2856bfec510abab89753fac1ac0e1112364e7d250545963f135f2a33188ed"
                );
                public static readonly KeyDerivationTestVector Test2 = new(
                    DerivationChain: "m/0'",
                    ChainCode: "8b59aa11380b624e81507a27fedda59fea6d0b779a778918a2fd3590e16e9c69",
                    PrivateKeyBytes: "68e0fe46dfb67e368c75379acec591dad19df3cde26e63b93a8e704f1dade7a3",
                    PublicKeyBytes: "008c8a13df77a28f3445213a0f432fde644acaa215fc72dcdf300d5efaa85d350c"
                );
                public static readonly KeyDerivationTestVector Test3 = new(
                    DerivationChain: "m/0'/1'",
                    ChainCode: "a320425f77d1b5c2505a6b1b27382b37368ee640e3557c315416801243552f14",
                    PrivateKeyBytes: "b1d0bad404bf35da785a64ca1ac54b2617211d2777696fbffaf208f746ae84f2",
                    PublicKeyBytes: "001932a5270f335bed617d5b935c80aedb1a35bd9fc1e31acafd5372c30f5c1187"
                );
                public static readonly KeyDerivationTestVector Test4 = new(
                    DerivationChain: "m/0'/1'/2'",
                    ChainCode: "2e69929e00b5ab250f49c3fb1c12f252de4fed2c1db88387094a0f8c4c9ccd6c",
                    PrivateKeyBytes: "92a5b23c0b8a99e37d07df3fb9966917f5d06e02ddbd909c7e184371463e9fc9",
                    PublicKeyBytes: "00ae98736566d30ed0e9d2f4486a64bc95740d89c7db33f52121f8ea8f76ff0fc1"
                );
                public static readonly KeyDerivationTestVector Test5 = new(
                    DerivationChain: "m/0'/1'/2'/2'",
                    ChainCode: "8f6d87f93d750e0efccda017d662a1b31a266e4a6f5993b15f5c1f07f74dd5cc",
                    PrivateKeyBytes: "30d1dc7e5fc04c31219ab25a27ae00b50f6fd66622f6e9c913253d6511d1e662",
                    PublicKeyBytes: "008abae2d66361c879b900d204ad2cc4984fa2aa344dd7ddc46007329ac76c429c"
                );
                public static readonly KeyDerivationTestVector Test6 = new(
                    DerivationChain: "m/0'/1'/2'/2'/1000000000'",
                    ChainCode: "68789923a0cac2cd5a29172a475fe9e0fb14cd6adb5ad98a3fa70333e7afa230",
                    PrivateKeyBytes: "8f94d394a8e8fd6b1bc2f3f49f5c47e385281d5c17e65324b0f62483e37e8793",
                    PublicKeyBytes: "003c24da049451555d51a7014a37337aa4e12d41e485abccfa46b47dfb2af54b7a"
                );
            }

            /// <summary>Derivation test vector 2 for ED25519</summary>
            public static class Ed25519Vector2
            {
                public const string Seed = "fffcf9f6f3f0edeae7e4e1dedbd8d5d2cfccc9c6c3c0bdbab7b4b1aeaba8a5a29f9c999693908d8a8784817e7b7875726f6c696663605d5a5754514e4b484542";

                public static readonly KeyDerivationTestVector Test1 = new(
                    DerivationChain: "m/",
                    ChainCode: "ef70a74db9c3a5af931b5fe73ed8e1a53464133654fd55e7a66f8570b8e33c3b",
                    PrivateKeyBytes: "171cb88b1b3c1db25add599712e36245d75bc65a1a5c9e18d76f9f2b1eab4012",
                    PublicKeyBytes: "008fe9693f8fa62a4305a140b9764c5ee01e455963744fe18204b4fb948249308a"
                );
                public static readonly KeyDerivationTestVector Test2 = new(
                    DerivationChain: "m/0'",
                    ChainCode: "0b78a3226f915c082bf118f83618a618ab6dec793752624cbeb622acb562862d",
                    PrivateKeyBytes: "1559eb2bbec5790b0c65d8693e4d0875b1747f4970ae8b650486ed7470845635",
                    PublicKeyBytes: "0086fab68dcb57aa196c77c5f264f215a112c22a912c10d123b0d03c3c28ef1037"
                );
                public static readonly KeyDerivationTestVector Test3 = new(
                    DerivationChain: "m/0'/2147483647'",
                    ChainCode: "138f0b2551bcafeca6ff2aa88ba8ed0ed8de070841f0c4ef0165df8181eaad7f",
                    PrivateKeyBytes: "ea4f5bfe8694d8bb74b7b59404632fd5968b774ed545e810de9c32a4fb4192f4",
                    PublicKeyBytes: "005ba3b9ac6e90e83effcd25ac4e58a1365a9e35a3d3ae5eb07b9e4d90bcf7506d"
                );
                public static readonly KeyDerivationTestVector Test4 = new(
                    DerivationChain: "m/0'/2147483647'/1'",
                    ChainCode: "73bd9fff1cfbde33a1b846c27085f711c0fe2d66fd32e139d3ebc28e5a4a6b90",
                    PrivateKeyBytes: "3757c7577170179c7868353ada796c839135b3d30554bbb74a4b1e4a5a58505c",
                    PublicKeyBytes: "002e66aa57069c86cc18249aecf5cb5a9cebbfd6fadeab056254763874a9352b45"
                );
                public static readonly KeyDerivationTestVector Test5 = new(
                    DerivationChain: "m/0'/2147483647'/1'/2147483646'",
                    ChainCode: "0902fe8a29f9140480a00ef244bd183e8a13288e4412d8389d140aac1794825a",
                    PrivateKeyBytes: "5837736c89570de861ebc173b1086da4f505d4adb387c6a1b1342d5e4ac9ec72",
                    PublicKeyBytes: "00e33c0f7d81d843c572275f287498e8d408654fdf0d1e065b84e2e6f157aab09b"
                );
                public static readonly KeyDerivationTestVector Test6 = new(
                    DerivationChain: "m/0'/2147483647'/1'/2147483646'/2'",
                    ChainCode: "5d70af781f3a37b829f0d060924d5e960bdc02e85423494afc0b1a41bbe196d4",
                    PrivateKeyBytes: "551d333177df541ad876a60ea71f00447931c0a9da16f227c11ea080d7391b8d",
                    PublicKeyBytes: "0047150c75db263559a70d5778bf36abbab30fb061ad69f69ece61a72b0cfa4fc0"
                );
            }
        }

        #endregion

        #region ED25519 Key Derivation

        /// <summary>
        /// Test vectors provided by Hedera.
        /// Test for proper ED25519 key derivation from a given mnemonic and derivation chain.
        /// </summary>
        public static class Ed25519KeyDerivation
        {
            public record KeyDerivationTestVector(string DerivationChain, string PrivateKeyBytes, string PublicKeyBytes);
            public record StandardKeyDerivationTestVector(string Passphrase, string DerivationChain, string ChainCode, string PrivateKeyBytes, string PublicKeyBytes);

            /// <summary>Legacy v1 Derivation</summary>
            public static class LegacyV1
            {
                public const string Mnemonic = "jolly kidnap tom lawn drunk chick optic lust mutter mole bride galley dense member sage neural widow decide curb aboard margin manure";

                public static readonly KeyDerivationTestVector Test1 = new(
                    DerivationChain: "m/",
                    PrivateKeyBytes: "551d333177df541ad876a60ea71f00447931c0a9da16f227c11ea080d7391b8d",
                    PublicKeyBytes: "0047150c75db263559a70d5778bf36abbab30fb061ad69f69ece61a72b0cfa4fc0"
                );
                public static readonly KeyDerivationTestVector Test2 = new(
                    DerivationChain: "m/0",
                    PrivateKeyBytes: "fae0002d2716ea3a60c9cd05ee3c4bb88723b196341b68a02d20975f9d049dc6",
                    PublicKeyBytes: "f40f9fdb1f161c31ed656794ada7af8025e8b5c70e538f38a4dfb46a0a6b0392"
                );
                public static readonly KeyDerivationTestVector Test3 = new(
                    DerivationChain: "m/0/-1",
                    PrivateKeyBytes: "882a565ad8cb45643892b5366c1ee1c1ef4a730c5ce821a219ff49b6bf173ddf",
                    PublicKeyBytes: "53c6b451e695d6abc52168a269316a0d20deee2331f612d4fb8b2b379e5c6854"
                );
                public static readonly KeyDerivationTestVector Test4 = new(
                    DerivationChain: "m/1099511627775",
                    PrivateKeyBytes: "6890dc311754ce9d3fc36bdf83301aa1c8f2556e035a6d0d13c2cccdbbab1242",
                    PublicKeyBytes: "45f3a673984a0b4ee404a1f4404ed058475ecd177729daa042e437702f7791e9"
                );
            }

            /// <summary>Legacy v2 Derivation</summary>
            public static class LegacyV2
            {
                public const string Mnemonic = "obvious favorite remain caution remove laptop base vacant increase video erase pass sniff sausage knock grid argue salt romance way alone fever slush dune";

                public static readonly KeyDerivationTestVector Test1 = new(
                    DerivationChain: "m/",
                    PrivateKeyBytes: "98aa82d6125b5efa04bf8372be7931d05cd77f5ef3330b97d6ee7c006eaaf312",
                    PublicKeyBytes: "e0ce688d614f22f96d9d213ca513d58a7d03d954fe45790006e6e86b25456465"
                );
                public static readonly KeyDerivationTestVector Test2 = new(
                    DerivationChain: "m/0",
                    PrivateKeyBytes: "2b7345f302a10c2a6d55bf8b7af40f125ec41d780957826006d30776f0c441fb",
                    PublicKeyBytes: "0e19f99800b007cc7c82f9d85b73e0f6e48799469450caf43f253b48c4d0d91a"
                );
                public static readonly KeyDerivationTestVector Test3 = new(
                    DerivationChain: "m/-1",
                    PrivateKeyBytes: "caffc03fdb9853e6a91a5b3c57a5c0031d164ce1c464dea88f3114786b5199e5",
                    PublicKeyBytes: "9fe11da3fcfba5d28a6645ecb611a9a43dbe6014b102279ba1d34506ea86974b"
                );
            }

            /// <summary>12 Word Standard Derivation</summary>
            public static class TwelveWordStandard
            {
                public const string Mnemonic = "finish furnace tomorrow wine mass goose festival air palm easy region guilt";

                public static readonly StandardKeyDerivationTestVector Test1 = new(
                    Passphrase: "",
                    DerivationChain: "m/44'/3030'/0'/0'/0'",
                    ChainCode: "48c89d67e9920e443f09d2b14525213ff83b245c8b98d63747ea0801e6d0ff3f",
                    PrivateKeyBytes: "020487611f3167a68482b0f4aacdeb02cc30c52e53852af7b73779f67eeca3c5",
                    PublicKeyBytes: "2d047ff02a2091f860633f849ea2024b23e7803cfd628c9bdd635010cbd782d3"
                );
                public static readonly StandardKeyDerivationTestVector Test2 = new(
                    Passphrase: "",
                    DerivationChain: "m/44'/3030'/0'/0'/2147483647'",
                    ChainCode: "c0bcdbd9df6d8a4f214f20f3e5c7856415b68be34a1f406398c04690818bea16",
                    PrivateKeyBytes: "d0c4484480944db698dd51936b7ecc81b0b87e8eafc3d5563c76339338f9611a",
                    PublicKeyBytes: "a1a2573c2c45bd57b0fd054865b5b3d8f492a6e1572bf04b44471e07e2f589b2"
                );
                public static readonly StandardKeyDerivationTestVector Test3 = new(
                    Passphrase: "some pass",
                    DerivationChain: "m/44'/3030'/0'/0'/0'",
                    ChainCode: "998a156855ab5398afcde06164b63c5523ff2c8900db53962cc2af191df59e1c",
                    PrivateKeyBytes: "d06630d6e4c17942155819bbbe0db8306cd989ba7baf3c29985c8455fbefc37f",
                    PublicKeyBytes: "6bd0a51e0ca6fcc8b13cf25efd0b4814978bcaca7d1cf7dbedf538eb02969acb"
                );
                public static readonly StandardKeyDerivationTestVector Test4 = new(
                    Passphrase: "some pass",
                    DerivationChain: "m/44'/3030'/0'/0'/2147483647'",
                    ChainCode: "19d99506a5ce2dc0080092068d278fe29b85ffb8d9c26f8956bfca876307c79c",
                    PrivateKeyBytes: "a095ef77ee88da28f373246e9ae143f76e5839f680746c3f921e90bf76c81b08",
                    PublicKeyBytes: "35be6a2a37ff6bbb142e9f4d9b558308f4f75d7c51d5632c6a084257455e1461"
                );
            }

            /// <summary>24 Word Standard Derivation</summary>
            public static class TwentyFourWordStandard
            {
                public const string Mnemonic = "inmate flip alley wear offer often piece magnet surge toddler submit right radio absent pear floor belt raven price stove replace reduce plate home";

                public static readonly StandardKeyDerivationTestVector Test1 = new(
                    Passphrase: "",
                    DerivationChain: "m/44'/3030'/0'/0'/0'",
                    ChainCode: "404914563637c92d688deb9d41f3f25cbe8d6659d859cc743712fcfac72d7eda",
                    PrivateKeyBytes: "f8dcc99a1ced1cc59bc2fee161c26ca6d6af657da9aa654da724441343ecd16f",
                    PublicKeyBytes: "2e42c9f5a5cdbde64afa65ce3dbaf013d5f9ff8d177f6ef4eb89fbe8c084ec0d"
                );
                public static readonly StandardKeyDerivationTestVector Test2 = new(
                    Passphrase: "",
                    DerivationChain: "m/44'/3030'/0'/0'/2147483647'",
                    ChainCode: "9c2b0073ac934696cd0b52c6c521b9bd1902aac134380a737282fdfe29014bf1",
                    PrivateKeyBytes: "e978a6407b74a0730f7aeb722ad64ab449b308e56006c8bff9aad070b9b66ddf",
                    PublicKeyBytes: "c4b33dca1f83509f17b69b2686ee46b8556143f79f4b9df7fe7ed3864c0c64d0"
                );
                public static readonly StandardKeyDerivationTestVector Test3 = new(
                    Passphrase: "some pass",
                    DerivationChain: "m/44'/3030'/0'/0'/0'",
                    ChainCode: "699344acc5e07c77eb63b154b4c5c3d33cab8bf85ee21bea4cc29ab7f0502259",
                    PrivateKeyBytes: "abeca64d2337db386e289482a252334c68c7536daaefff55dc169ddb77fbae28",
                    PublicKeyBytes: "fd311925a7a04b38f7508931c6ae6a93e5dc4394d83dafda49b051c0017d3380"
                );
                public static readonly StandardKeyDerivationTestVector Test4 = new(
                    Passphrase: "some pass",
                    DerivationChain: "m/44'/3030'/0'/0'/2147483647'",
                    ChainCode: "e5af7c95043a912af57a6e031ddcad191677c265d75c39954152a2733c750a3b",
                    PrivateKeyBytes: "9a601db3e24b199912cec6573e6a3d01ffd3600d50524f998b8169c105165ae5",
                    PublicKeyBytes: "cf525500706faa7752dca65a086c9381d30d72cc67f23bf334f330579074a890"
                );
            }
        }

        #endregion

        #region ECDSAsecp256k1 Key Derivation

        /// <summary>
        /// Test vectors provided by Hedera.
        /// Test for proper ECDSAsecp256k1 key derivation from a given mnemonic and derivation chain.
        /// </summary>
        public static class EcdsaSecp256k1KeyDerivation
        {
            public record StandardKeyDerivationTestVector(string Passphrase, string DerivationChain, string ChainCode, string PrivateKeyBytes, string PublicKeyBytes);

            /// <summary>12 Word Standard Derivation</summary>
            public static class TwelveWordStandard
            {
                public const string Mnemonic = "finish furnace tomorrow wine mass goose festival air palm easy region guilt";

                public static readonly StandardKeyDerivationTestVector Test1 = new(
                    Passphrase: "",
                    DerivationChain: "m/44'/3030'/0'/0/0",
                    ChainCode: "e76e0480faf2790e62dc1a7bac9dce51db1b3571fd74d8e264abc0d240a55d09",
                    PrivateKeyBytes: "f033824c20dd9949ad7a4440f67120ee02a826559ed5884077361d69b2ad51dd",
                    PublicKeyBytes: "0294bf84a54806989a74ca4b76291d386914610b40b610d303162b9e495bc06416"
                );
                public static readonly StandardKeyDerivationTestVector Test2 = new(
                    Passphrase: "",
                    DerivationChain: "m/44'/3030'/0'/0/0'",
                    ChainCode: "60c39c6a77bd68c0aaabfe2f4711dc9c2247214c4f4dae15ad4cb76905f5f544",
                    PrivateKeyBytes: "962f549dafe2d9c8091ac918cb4fc348ab0767353f37501067897efbc84e7651",
                    PublicKeyBytes: "027123855357fd41d28130fbc59053192b771800d28ef47319ef277a1a032af78f"
                );
                public static readonly StandardKeyDerivationTestVector Test3 = new(
                    Passphrase: "some pass",
                    DerivationChain: "m/44'/3030'/0'/0/0",
                    ChainCode: "911a1095b64b01f7f3a06198df3d618654e5ed65862b211997c67515e3167892",
                    PrivateKeyBytes: "c139ebb363d7f441ccbdd7f58883809ec0cc3ee7a122ef67974eec8534de65e8",
                    PublicKeyBytes: "0293bdb1507a26542ed9c1ec42afe959cf8b34f39daab4bf842cdac5fa36d50ef7"
                );
                public static readonly StandardKeyDerivationTestVector Test4 = new(
                    Passphrase: "some pass",
                    DerivationChain: "m/44'/3030'/0'/0/0'",
                    ChainCode: "64173f2dcb1d65e15e787ef882fa15f54db00209e2dab16fa1661244cd98e95c",
                    PrivateKeyBytes: "87c1d8d4bb0cebb4e230852f2a6d16f6847881294b14eb1d6058b729604afea0",
                    PublicKeyBytes: "03358e7761a422ca1c577f145fe845c77563f164b2c93b5b34516a8fa13c2c0888"
                );
                public static readonly StandardKeyDerivationTestVector Test5 = new(
                    Passphrase: "some pass",
                    DerivationChain: "m/44'/3030'/0'/0/2147483647",
                    ChainCode: "a7250c2b07b368a054f5c91e6a3dbe6ca3bbe01eb0489fe8778304bd0a19c711",
                    PrivateKeyBytes: "2583170ee745191d2bb83474b1de41a1621c47f6e23db3f2bf413a1acb5709e4",
                    PublicKeyBytes: "03f9eb27cc73f751e8e476dd1db79037a7df2c749fa75b6cc6951031370d2f95a5"
                );
                public static readonly StandardKeyDerivationTestVector Test6 = new(
                    Passphrase: "some pass",
                    DerivationChain: "m/44'/3030'/0'/0/2147483647'",
                    ChainCode: "66a1175e7690e3714d53ffce16ee6bb4eb02065516be2c2ad6bf6c9df81ec394",
                    PrivateKeyBytes: "f2d008cd7349bdab19ed85b523ba218048f35ca141a3ecbc66377ad50819e961",
                    PublicKeyBytes: "027b653d04958d4bf83dd913a9379b4f9a1a1e64025a691830a67383bc3157c044"
                );
            }

            /// <summary>24 Word Standard Derivation</summary>
            public static class TwentyFourWordStandard
            {
                public const string Mnemonic = "inmate flip alley wear offer often piece magnet surge toddler submit right radio absent pear floor belt raven price stove replace reduce plate home";

                public static readonly StandardKeyDerivationTestVector Test1 = new(
                    Passphrase: "",
                    DerivationChain: "m/44'/3030'/0'/0/0",
                    ChainCode: "7717bc71194c257d4b233e16cf48c24adef630052f874a262d19aeb2b527620d",
                    PrivateKeyBytes: "0fde7bfd57ae6ec310bdd8b95967d98e8762a2c02da6f694b152cf9860860ab8",
                    PublicKeyBytes: "03b1c064b4d04d52e51f6c8e8bb1bff75d62fa7b1446412d5901d424f6aedd6fd4"
                );
                public static readonly StandardKeyDerivationTestVector Test2 = new(
                    Passphrase: "",
                    DerivationChain: "m/44'/3030'/0'/0/0'",
                    ChainCode: "e333da4bd9e21b5dbd2b0f6d88bad02f0fa24cf4b70b2fb613368d0364cdf8af",
                    PrivateKeyBytes: "aab7d720a32c2d1ea6123f58b074c865bb07f6c621f14cb012f66c08e64996bb",
                    PublicKeyBytes: "03a0ea31bb3562f8a309b1436bc4b2f537301778e8a5e12b68cec26052f567a235"
                );
                public static readonly StandardKeyDerivationTestVector Test3 = new(
                    Passphrase: "some pass",
                    DerivationChain: "m/44'/3030'/0'/0/0",
                    ChainCode: "0ff552587f6baef1f0818136bacac0bb37236473f6ecb5a8c1cc68a716726ed1",
                    PrivateKeyBytes: "6df5ed217cf6d5586fdf9c69d39c843eb9d152ca19d3e41f7bab483e62f6ac25",
                    PublicKeyBytes: "0357d69bb36fee569838fe7b325c07ca511e8c1b222873cde93fc6bb541eb7ecea"
                );
                public static readonly StandardKeyDerivationTestVector Test4 = new(
                    Passphrase: "some pass",
                    DerivationChain: "m/44'/3030'/0'/0/0'",
                    ChainCode: "3a5048e93aad88f1c42907163ba4dce914d3aaf2eea87b4dd247ca7da7530f0b",
                    PrivateKeyBytes: "80df01f79ee1b1f4e9ab80491c592c0ef912194ccca1e58346c3d35cb5b7c098",
                    PublicKeyBytes: "039ebe79f85573baa065af5883d0509a5634245f7864ddead76a008c9e42aa758d"
                );
                public static readonly StandardKeyDerivationTestVector Test5 = new(
                    Passphrase: "some pass",
                    DerivationChain: "m/44'/3030'/0'/0/2147483647",
                    ChainCode: "e54254940db58ef4913a377062ac6e411daebf435ad592d262d5a66d808a8b94",
                    PrivateKeyBytes: "60cb2496a623e1201d4e0e7ce5da3833cd4ec7d6c2c06bce2bcbcbc9dfef22d6",
                    PublicKeyBytes: "02b59f348a6b69bd97afa80115e2d5331749b3c89c61297255430c487d6677f404"
                );
                public static readonly StandardKeyDerivationTestVector Test6 = new(
                    Passphrase: "some pass",
                    DerivationChain: "m/44'/3030'/0'/0/2147483647'",
                    ChainCode: "cb23165e9d2d798c85effddc901a248a1a273fab2a56fe7976df97b016e7bb77",
                    PrivateKeyBytes: "100477c333028c8849250035be2a0a166a347a5074a8a727bce1db1c65181a50",
                    PublicKeyBytes: "03d10ebfa2d8ff2cd34aa96e5ef59ca2e69316b4c0996e6d5f54b6932fe51be560"
                );
            }
        }

        #endregion
    }
}
