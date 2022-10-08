using System;

public class MyMethods
{
	public MyMethods()
	{

	}
    public void SetOpacity(Form form, System.Drawing.Point location)
    {
        form.Show();
        form.Location = location;
        form.Size = new System.Drawing.Size(700, 500);
        form.Opacity = 0;
        for (int i = 0; i < 50; i++)
        {
            //await Task.Delay(1);
            form.Size = new System.Drawing.Size(form.Size.Width, form.Size.Height + 2);
            form.Location = new System.Drawing.Point(form.Location.X, form.Location.Y - 2);
            form.Opacity += 0.02;
        }
    }
}
