namespace PochtaAPI.Enums
{
    /// <summary>
    /// Тип посылки
    /// </summary>
    public enum ProductType
    {
        /// <summary>
        /// Заказное письмо
        /// </summary>
        LETTER_ORDERED,

        /// <summary>
        /// Письмо с объявленной ценностью
        /// </summary>
        LETTER_WITH_DECLARED_VALUE,

        /// <summary>
        /// Письмо с объявленной ценностью и наложенным платежом
        /// </summary>
        LETTER_WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY,

        /// <summary>
        /// Международное заказное письмо
        /// </summary>
        INTERNATIONAL_LETTER_ORDERED,

        /// <summary>
        /// Простая бандероль (консолидатор)
        /// </summary>
        BANDEROL_SIMPLE,

        /// <summary>
        /// Заказная бандероль
        /// </summary>
        BANDEROL_ORDERED,

        /// <summary>
        /// Бандероль с объявленной ценностью
        /// </summary>
        BANDEROL_WITH_DECLARED_VALUE,

        /// <summary>
        /// Бандероль с объявленной ценностью и наложенным платежом
        /// </summary>
        BANDEROL_WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY,

        /// <summary>
        /// Посылка обыкновенная
        /// </summary>
        POSTAL_PARCEL_ORDINARY,

        /// <summary>
        /// Посылка с объявленной ценностью
        /// </summary>
        POSTAL_PARCEL_WITH_DECLARED_VALUE,

        /// <summary>
        /// Посылка с объявленной ценностью и наложенным платежом
        /// </summary>
        POSTAL_PARCEL_WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY,

        /// <summary>
        /// Посылка обыкновенная международная
        /// </summary>
        INTERNATIONAL_POSTAL_PARCEL_ORDINARY,

        /// <summary>
        /// EMS обыкновенное
        /// </summary>
        EMS_ORDINARY,

        /// <summary>
        /// EMS с объявленной ценностью
        /// </summary>
        EMS_WITH_DECLARED_VALUE,

        /// <summary>
        /// EMS с объявленной ценностью и наложенным платежом
        /// </summary>
        EMS_WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY,

        /// <summary>
        /// EMS оптимальное обыкновенное
        /// </summary>
        EMS_OPTIMAL_ORDINARY,

        /// <summary>
        /// EMS оптимальное с объявленной ценностью
        /// </summary>
        EMS_OPTIMAL_WITH_DECLARED_VALUE,

        /// <summary>
        /// EMS оптимальное с объявленной ценностью и наложенным платежом
        /// </summary>
        EMS_OPTIMAL_WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY,

        /// <summary>
        /// EMS РТ
        /// </summary>
        EMS_RT_ORDINARY,

        /// <summary>
        /// EMS с объявленной ценностью
        /// </summary>
        EMS_RT_WITH_DECLARED_VALUE,

        /// <summary>
        /// Посылка онлайн обыкновенная
        /// </summary>
        ONLINE_PARCEL_ORDINARY,

        /// <summary>
        /// Посылка онлайн с объявленной ценностью
        /// </summary>
        ONLINE_PARCEL_WITH_DECLARED_VALUE,

        /// <summary>
        /// Посылка онлайн с объявленной ценностью и наложенным платежом
        /// </summary>
        ONLINE_PARCEL_WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY,

        /// <summary>
        /// Курьер онлайн обыкновенное
        /// </summary>
        ONLINE_COURIER_ORDINARY,

        /// <summary>
        /// Курьер онлайн с объявленной ценностью
        /// </summary>
        ONLINE_COURIER_WITH_DECLARED_VALUE,

        /// <summary>
        /// Курьер онлайн с объявленной ценностью и наложенным платежом
        /// </summary>
        ONLINE_COURIER_WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY,

        /// <summary>
        /// Бизнес Курьер обыкновненное
        /// </summary>
        BUSINESS_COURIER_ORDINARY,

        /// <summary>
        /// Бизнес Курьер с объявленной ценностью
        /// </summary>
        BUSINESS_COURIER_WITH_DECLARED_VALUE,

        /// <summary>
        /// Бизнес Курьер экспресс обыкновненное
        /// </summary>
        BUSINESS_COURIER_ES_ORDINARY,

        /// <summary>
        /// Бизнес Курьер экспресс с объявленной ценностью
        /// </summary>
        BUSINESS_COURIER_ES_WITH_DECLARED_VALUE,

        /// <summary>
        /// Посылка 1-го класса обыкновенная
        /// </summary>
        PARCEL_CLASS_1_ORDINARY,

        /// <summary>
        /// Посылка 1-го класса с объявленной ценностью
        /// </summary>
        PARCEL_CLASS_1_WITH_DECLARED_VALUE,

        /// <summary>
        /// Посылка 1-го класса с объявленной ценностью и наложенным платежом
        /// </summary>
        PARCEL_CLASS_1_WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY,

        /// <summary>
        /// Письмо 1-го класса заказное
        /// </summary>
        LETTER_CLASS_1_ORDERED,

        /// <summary>
        /// Письмо 1-го класса с объявленной ценностью
        /// </summary>
        LETTER_CLASS_1_WITH_DECLARED_VALUE,

        /// <summary>
        /// Письмо 1-го класса с объявленной ценностью и наложенным платежом
        /// </summary>
        LETTER_CLASS_1_WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY,

        /// <summary>
        /// Бандероль 1 класса заказное
        /// </summary>
        BANDEROL_CLASS_1_ORDERED,

        /// <summary>
        /// Бандероль 1 класса с объявленной ценностью
        /// </summary>
        BANDEROL_CLASS_1_WITH_DECLARED_VALUE,

        /// <summary>
        /// Бандероль 1 класса с объявленной ценностью и наложенным платежом
        /// </summary>
        BANDEROL_CLASS_1_WITH_DECLARED_VALUE_AND_CASH_ON_DELIVERY,

        /// <summary>
        /// Письмо обыкновенное (консолидатор)
        /// </summary>
        LETTER_SIMPLE,

        /// <summary>
        /// Простое письмо единичное
        /// </summary>
        SINGLE_LETTER_SIMPLE,

        /// <summary>
        /// Простая бандероль единичная
        /// </summary>
        SINGLE_BANDEROL_SIMPLE,

        /// <summary>
        /// Мелкий пакет заказной
        /// </summary>
        SMALL_PACKET_ORDERED,

        /// <summary>
        /// EMS международное обыкновенное
        /// </summary>
        INTERNATIONAL_EMS_ORDINARY,

        /// <summary>
        /// Международное простое письмо
        /// </summary>
        INTERNATIONAL_SINGLE_LETTER_SIMPLE,

        /// <summary>
        /// ВГПО 1-го класса заказное
        /// </summary>
        VGPO_CLASS_1_ORDERED,

        /// <summary>
        /// ВГПО 1-го класса простое
        /// </summary>
        VGPO_CLASS_1_SIMPLE,

        /// <summary>
        /// EMS Тендер
        /// </summary>
        EMS_TENDER_ORDINARY,

        /// <summary>
        /// EMS Тендер с объявленной ценностью
        /// </summary>
        EMS_TENDER_WITH_DECLARED_VALUE,

        /// <summary>
        /// Отправление ВСД
        /// </summary>
        VSD_ORDINARY,

        /// <summary>
        /// ЕКОМ обыкновенное
        /// </summary>
        ECOM_ORDINARY,

        /// <summary>
        /// ЕКОМ с обязательным платежом
        /// </summary>
        ECOM_WITH_COMPULSORY_PAYMENT,

        /// <summary>
        /// ЕКОМ Маркетплейс с объявленной ценностью
        /// </summary>
        ECOM_MARKETPLACE_WITH_DECLARED_VALUE,

        /// <summary>
        /// Легкий возврат обыкновенное
        /// </summary>
        EASY_RETURN_ORDINARY,

        /// <summary>
        /// Легкий возврат с объявленной ценностью
        /// </summary>
        EASY_RETURN_WITH_DECLARED_VALUE
    }
}