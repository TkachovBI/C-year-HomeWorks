using MyPhotoshop.Data;
using System;

namespace MyPhotoshop
{
	public class Photo
	{
		public readonly int width;
		public readonly int height;
		public Pixel[,] data;

        public Photo(int w, int h)
        {
            width = w;
            height = h;

            data = new Pixel[w, h];
            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    data[x, y] = new Pixel();
                }
            }
        }
	}
}

