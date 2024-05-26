namespace Domain.DTOs.RoomDto;

public class GetRoomDto
{
    public int Id { get; set; }
    public string RoomNumber { get; set; }
    public string? Description { get; set; }
    public string Type { get; set; }
    public decimal PricePerNight { get; set; }
    public string Status { get; set; }
    public string? Photo { get; set; }
}