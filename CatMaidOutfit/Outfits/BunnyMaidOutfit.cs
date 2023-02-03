using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace KitchenCatMaidOutfit.Outfits
{
    public class BunnyMaidOutfit : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "bunnymaidoutfit";
        public override CosmeticType CosmeticType => CosmeticType.Outfit;
        public override GameObject Visual => Main.bundle.LoadAsset<GameObject>("BunnyMaidOutfit");

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;


            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Bunny Maid Dress").GetComponent<SkinnedMeshRenderer>());

            MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "Bunny Maid Dress", new Material[] {
                MaterialUtils.GetExistingMaterial("Clothing Pink"),
                MaterialUtils.GetExistingMaterial("Clothing White")
            });
        }
    }
}