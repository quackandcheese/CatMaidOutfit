using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace KitchenCatMaidOutfit.Hats
{
    public class BearMaidHat : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "bearmaidhat";
        public override CosmeticType CosmeticType => CosmeticType.Hat;
        public override GameObject Visual => Main.bundle.LoadAsset<GameObject>("BearMaidHat");
        public override bool BlockHats => true;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Bear Maid Headband").GetComponent<SkinnedMeshRenderer>());

            MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "Bear Maid Headband", new Material[] {
                MaterialUtils.GetExistingMaterial("Wood - Barrel"), //or Wood 1 - Dim
                MaterialUtils.GetExistingMaterial("Dirt 2")
            });
        }
    }
}