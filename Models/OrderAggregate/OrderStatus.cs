using System.Runtime.Serialization;

namespace MyAppBack.Models.OrderAggregate
{
  public enum OrderStatus
  {
    [EnumMember(Value = "Товар ожидает оплаты")]
    Pending,

    [EnumMember(Value = "Оплата получена, готовим заказ к отправке")]
    PaymentReceived,

    [EnumMember(Value = "Платеж не прошел, мы свяжемся с вами")]
    PaymentFailed,

    [EnumMember(Value = "Заказ передан в доставку")]
    OrderShiped,

    [EnumMember(Value = "Заказ доставлен")]
    OrderDelivered
  }
}