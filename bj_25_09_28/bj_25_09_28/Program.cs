internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] h = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int[] s = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int[] v = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int[] rgb = isr.ReadLine().Split().Select(int.Parse).ToArray();

        int M = Math.Max(rgb[0], Math.Max(rgb[1], rgb[2]));
        int m = Math.Min(rgb[0], Math.Min(rgb[1], rgb[2]));

        double H = 0;

        if (M == rgb[0])
        {
            H = 60.0 * (rgb[1] - rgb[2]) / (M - m);
        }

        if (M == rgb[1])
        {
            H = 120.0 + 60.0 * (rgb[2] - rgb[0]) / (M - m);
        }

        if (M == rgb[2])
        {
            H = 240.0 + 60.0 * (rgb[0] - rgb[1]) / (M - m);
        }

        if (H < 0)
        {
            H += 360;
        }

        double S = 255.0 * (M - m) / M;
        double V = M;

        if (H >= h[0] && H <= h[1] && S >= s[0] && S <= s[1] && V >= v[0] && V <= v[1])
        {
            Console.WriteLine("Lumi will like it.");
        }
        else
        {
            Console.WriteLine("Lumi will not like it.");
        }
    }
}