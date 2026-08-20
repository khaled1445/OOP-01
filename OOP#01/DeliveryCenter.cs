using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_01
{
    internal struct DeliveryCenter
    {
        private Shipment[] shipments;
        private const int Capacity = 10;
        public Shipment this[int index]
        {
            get
            {
                if (shipments == null || index < 0 || index >= shipments.Length)
                    return default;
                return shipments[index];
            }
            set
            {
                if (shipments == null)
                    shipments = new Shipment[Capacity];

                if (index < 0 || index >= shipments.Length)
                    return;

                shipments[index] = value;
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                foreach (var shipment in shipments)
                {
                    if (shipment.TrackingCode != null &&
                        shipment.TrackingCode.Equals(trackingCode, StringComparison.OrdinalIgnoreCase))
                        return shipment;
                }
                return default;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            if (shipments == null)
                shipments = new Shipment[Capacity];

            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i].TrackingCode == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false; 
        }

    }
}
