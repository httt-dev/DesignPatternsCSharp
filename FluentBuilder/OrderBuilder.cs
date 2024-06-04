using System;

namespace FluentBuilder
{
    public class OrderBuilder
    {
        private int _number;
        private DateTime _createdOn;
        private readonly AddressBuilder _addressBuilder = AddressBuilder.Empty();
        private OrderBuilder()
        {
            
        }

        public static OrderBuilder Empty()
        {
            return new OrderBuilder();
        }

        public OrderBuilder WithNumber(int number)
        {
            _number = number;
            return this;
        }

        public OrderBuilder WithCreatedOn(DateTime createdOn)
        {
            _createdOn = createdOn;
            return this;
        }

        public OrderBuilder WithShippingAddress(Action<AddressBuilder> action)
        {
            action(_addressBuilder);
            return this;
        }
        public Order Build()
        {
            return new Order
            {
                Number = _number,
                CreatedOn = _createdOn,
                ShippingAddress = _addressBuilder.Build()
                
            };
        }
        
    }

    public class AddressBuilder
    {
        private string _street;
        private string _city;

        private AddressBuilder()
        {
            
        }

        public static AddressBuilder Empty()
        {
            return new AddressBuilder();
        }

        public AddressBuilder Street(string street)
        {
            _street = street;
            return this;
        }
        
        public AddressBuilder City(string city)
        {
            _city = city;
            return this;
        }

        public Address Build()
        {
            return new Address
            {
                City = _city,
                Street = _street
            };
        }
    }
}