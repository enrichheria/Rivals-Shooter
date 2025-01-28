public class GameUI : BaseCanvasUI
{
   public override void Show()
   {
      base.Show();
      
      Services.UI.Get<InputUI>().Show();
   }

   public override void Hide()
   {
      base.Hide();
      
      Services.UI.Get<InputUI>().Hide();
   }
}