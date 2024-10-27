using System;
using Abp.Module.Customer;
using Volo.Abp;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Settings;

namespace Abp.Module.Customers;

public class ContactInformation : Entity
{
    public virtual Guid CustomerId { get; protected set; }
    public virtual string Name { get; protected set; }
    public virtual ContactInformationType Type { get; protected set; }
    public virtual string Value { get; protected set; }

    public ContactInformation() {}

    internal ContactInformation(Guid customerId, string name,  ContactInformationType type, string value)
    {
        CustomerId = customerId;
        SetName(name);
        Type = type;
        SetValue(value);
    }

    internal virtual void SetName(string name)
    {
        Check.NotNullOrWhiteSpace(name, nameof(Name),ContactInformationConsts.MaxNameLength);
    }

    public virtual void SetValue(string value)
    {
        Check.NotNullOrWhiteSpace(value, nameof(Value),ContactInformationConsts.MaxValueLength);
    }

    public override object?[] GetKeys()
    {
        return new object?[] { CustomerId, Name };
    }
}