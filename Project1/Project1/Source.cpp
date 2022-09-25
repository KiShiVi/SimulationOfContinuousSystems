void form_r()
{
	int in_r[3][3] = { {0,0},{1,2},{0,1} };
	float z_r[3] = {0,0.5,0.2 };
	float w[3][3] = { {0,0,0}, {0,0,0}, {0,0,0} };
	int i, j, g;
	for (int kr = 1; kr <= 2; kr++)
		for (int l = 0; l <= 1; l++)
		{
			i = in_r[kr][l];
			if (i == 0) continue;
			for (int m = 0; m <= 1; m++)
			{
				j = in_r[kr][m];
				if (j == 0) continue;
				g = (1 - 2 * l) * (1 - 2 * m);
				w[i][j] += g / z_r[kr];
			}
		}
}
void main() {
	form_r();
}