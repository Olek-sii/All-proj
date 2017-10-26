import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class XCommand 
{
	XData data = new XData();
	
	ActionType aType = new ActionType();
	
	class ActionType implements ActionListener
	{
		@Override
		public void actionPerformed(ActionEvent e) 
		{
			switch (e.getActionCommand()) 
			{
				case "Rect": data.t = 0; break;
				case "Oval": data.t = 1; break;
				case "RRec": data.t = 2; break;
				case "Line": data.t = 3; break;
			}			
		}
	}
}
