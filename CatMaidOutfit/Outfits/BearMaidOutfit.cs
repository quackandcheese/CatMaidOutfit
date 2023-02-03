using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace KitchenCatMaidOutfit.Outfits
{
    public class BearMaidOutfit : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "bearmaidoutfit";
        public override CosmeticType CosmeticType => CosmeticType.Outfit;
        public override GameObject Visual => Main.bundle.LoadAsset<GameObject>("BearMaidOutfit");

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Bear Maid Dress").GetComponent<SkinnedMeshRenderer>());

            MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "Bear Maid Dress", new Material[] {
                MaterialUtils.GetExistingMaterial("Wood - Barrel"), //or Wood 1 - Dim
                MaterialUtils.GetExistingMaterial("Cloth - Cheap"), // or Outside Floor
                MaterialUtils.GetExistingMaterial("Dirt 2")
            });
        }
    }
}