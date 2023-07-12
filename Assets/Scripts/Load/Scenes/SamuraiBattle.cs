using UI;
using UnityEngine.EventSystems;

namespace Load.Scenes
{
  public class SamuraiBattle : SceneStarter, IScreenClickable
  {
    public Player_Battles player;
    
    public override void OnStart()
    {
      PlayBGM("samurai");
    }
    
    public void OnScreenClick(PointerEventData eventData)
    {
      player.Attack();
    }
    
  }
}