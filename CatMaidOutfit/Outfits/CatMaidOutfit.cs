using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace KitchenCatMaidOutfit.Outfits
{
    public class CatMaidOutfit : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "catmaidoutfit";
        public override CosmeticType CosmeticType => CosmeticType.Outfit;
        public override GameObject Visual => Main.bundle.LoadAsset<GameObject>("CatMaidOutfit");

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Cat Maid Dress").GetComponent<SkinnedMeshRenderer>());

            MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "Cat Maid Dress", new Material[] {
                MaterialUtils.GetExistingMaterial("Clothing Black"),
                MaterialUtils.GetExistingMaterial("Clothing White")
            });
        }
    }
}