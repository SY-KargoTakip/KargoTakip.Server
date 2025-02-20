using Ardalis.SmartEnum;

namespace KargoTakip.Server.Domain.Kargolarim;

public sealed class KargoDurumEnum : SmartEnum<KargoDurumEnum>
{
    public static KargoDurumEnum Bekliyor = new("Bekliyor", 0);
    public static KargoDurumEnum AracaTeslimEdildi = new("Araca Teslim Edildi", 1);
    public static KargoDurumEnum YolaCikti = new("Yola Çıktı", 2);
    public static KargoDurumEnum TeslimSubesineUlasti = new("Teslim Şubesine Ulaştı", 3);
    public static KargoDurumEnum TeslimIcinYolaCikti = new("Teslim İçin Yola Çıktı", 4);
    public static KargoDurumEnum AdresteKimseBulunamadi = new("Adreste Kimse Bulunamadı", 5);
    public KargoDurumEnum(string name, int value) : base(name, value)
    {
    }
}
