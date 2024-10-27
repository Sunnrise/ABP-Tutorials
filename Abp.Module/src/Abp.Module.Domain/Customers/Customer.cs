using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Abp.Module.Customer;
using Volo.Abp;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Localization;

namespace Abp.Module.Customers;

public class Customer : AggregateRoot<Guid>
{
    public virtual string Name { get; protected set; }
    public virtual string Surname { get; protected set; }
    public virtual Guid CustomerGroupId { get; internal set; }
    public virtual ICollection<ContactInformation> ContactInformations { get; protected set; }
    public virtual Address Address { get; set; }

    public Customer()
    {
        
    }

    public Customer(string name, string surname, Guid Id) : base(Id)
    {
        SetName(name);
        SetSurname(surname);
        ContactInformations = new Collection<ContactInformation>();
            
    }

    public virtual void SetSurname(string surname)
    {
        Check.NotNullOrWhiteSpace(surname, nameof(Surname), CustomerConsts.MaxSurnameLength);
    }

    public virtual void SetName(string name)
    {
        Check.NotNullOrWhiteSpace(name, nameof(Name), CustomerConsts.MaxSurnameLength);
    }

    public virtual ContactInformation AddContactInformation(
        string name,
        ContactInformationType type,
        string value)
    {
        if(ContactInformations.Any(x => x.Name == name))
            throw new UserFriendlyException($"{name} is already in use");
        var contactInformation = new ContactInformation(Id, name, type, value);
        ContactInformations.Add(contactInformation);
        
        return contactInformation;
    }
}