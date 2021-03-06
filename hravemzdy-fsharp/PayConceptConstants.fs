﻿namespace PayrollLibrary

type PayConcepts = 
    | CONCEPT_UNKNOWN = 0u
    | CONCEPT_SALARY_MONTHLY = 100u
    | CONCEPT_SCHEDULE_WEEKLY = 200u
    | CONCEPT_SCHEDULE_TERM = 201u
    | CONCEPT_TIMESHEET_PERIOD = 202u
    | CONCEPT_TIMESHEET_WORK = 203u
    | CONCEPT_HOURS_WORKING = 204u
    | CONCEPT_HOURS_ABSENCE = 205u
    | CONCEPT_TAX_INCOME_BASE = 300u
    | CONCEPT_INSURANCE_HEALTH_BASE = 301u
    | CONCEPT_INSURANCE_SOCIAL_BASE = 302u
    | CONCEPT_INSURANCE_HEALTH = 303u
    | CONCEPT_INSURANCE_SOCIAL = 304u
    | CONCEPT_SAVINGS_PENSIONS = 305u
    | CONCEPT_TAX_EMPLOYERS_HEALTH = 306u
    | CONCEPT_TAX_EMPLOYERS_SOCIAL = 307u
    | CONCEPT_TAX_CLAIM_PAYER = 308u
    | CONCEPT_TAX_CLAIM_DISABILITY = 309u
    | CONCEPT_TAX_CLAIM_STUDYING = 312u
    | CONCEPT_TAX_CLAIM_CHILD = 313u
    | CONCEPT_TAX_ADVANCE_BASE = 314u
    | CONCEPT_TAX_ADVANCE = 315u
    | CONCEPT_TAX_RELIEF_PAYER = 316u
    | CONCEPT_TAX_RELIEF_DISABILITY = 317u
    | CONCEPT_TAX_RELIEF_STUDYING = 318u
    | CONCEPT_TAX_RELIEF_CHILD = 319u
    | CONCEPT_TAX_BONUS_CHILD = 320u
    | CONCEPT_TAX_ADVANCE_FINAL = 321u
    | CONCEPT_TAX_WITHHOLD_BASE = 325u
    | CONCEPT_TAX_WITHHOLD = 326u
    | CONCEPT_INCOME_GROSS = 901u
    | CONCEPT_INCOME_NETTO = 902u

[<Class>]
type PayConceptRefs() = 
    static member REFCON_UNKNOWN with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_UNKNOWN, PayConcepts.CONCEPT_UNKNOWN.ToString())
    static member REFCON_SALARY_MONTHLY with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_SALARY_MONTHLY, PayConcepts.CONCEPT_SALARY_MONTHLY.ToString())
    static member REFCON_SCHEDULE_WEEKLY with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_SCHEDULE_WEEKLY, PayConcepts.CONCEPT_SCHEDULE_WEEKLY.ToString())
    static member REFCON_SCHEDULE_TERM with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_SCHEDULE_TERM, PayConcepts.CONCEPT_SCHEDULE_TERM.ToString())
    static member REFCON_TIMESHEET_PERIOD with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_TIMESHEET_PERIOD, PayConcepts.CONCEPT_TIMESHEET_PERIOD.ToString())
    static member REFCON_TIMESHEET_WORK with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_TIMESHEET_WORK, PayConcepts.CONCEPT_TIMESHEET_WORK.ToString())
    static member REFCON_HOURS_WORKING with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_HOURS_WORKING, PayConcepts.CONCEPT_HOURS_WORKING.ToString())
    static member REFCON_HOURS_ABSENCE with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_HOURS_ABSENCE, PayConcepts.CONCEPT_HOURS_ABSENCE.ToString())
    static member REFCON_TAX_INCOME_BASE with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_TAX_INCOME_BASE, PayConcepts.CONCEPT_TAX_INCOME_BASE.ToString())
    static member REFCON_INSURANCE_HEALTH_BASE with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_INSURANCE_HEALTH_BASE, PayConcepts.CONCEPT_INSURANCE_HEALTH_BASE.ToString())
    static member REFCON_INSURANCE_SOCIAL_BASE with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_INSURANCE_SOCIAL_BASE, PayConcepts.CONCEPT_INSURANCE_SOCIAL_BASE.ToString())
    static member REFCON_INSURANCE_HEALTH with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_INSURANCE_HEALTH, PayConcepts.CONCEPT_INSURANCE_HEALTH.ToString())
    static member REFCON_INSURANCE_SOCIAL with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_INSURANCE_SOCIAL, PayConcepts.CONCEPT_INSURANCE_SOCIAL.ToString())
    static member REFCON_SAVINGS_PENSIONS with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_SAVINGS_PENSIONS, PayConcepts.CONCEPT_SAVINGS_PENSIONS.ToString())
    static member REFCON_TAX_EMPLOYERS_HEALTH with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_TAX_EMPLOYERS_HEALTH, PayConcepts.CONCEPT_TAX_EMPLOYERS_HEALTH.ToString())
    static member REFCON_TAX_EMPLOYERS_SOCIAL with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_TAX_EMPLOYERS_SOCIAL, PayConcepts.CONCEPT_TAX_EMPLOYERS_SOCIAL.ToString())
    static member REFCON_TAX_CLAIM_PAYER with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_TAX_CLAIM_PAYER, PayConcepts.CONCEPT_TAX_CLAIM_PAYER.ToString())
    static member REFCON_TAX_CLAIM_DISABILITY with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_TAX_CLAIM_DISABILITY, PayConcepts.CONCEPT_TAX_CLAIM_DISABILITY.ToString())
    static member REFCON_TAX_CLAIM_STUDYING with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_TAX_CLAIM_STUDYING, PayConcepts.CONCEPT_TAX_CLAIM_STUDYING.ToString())
    static member REFCON_TAX_CLAIM_CHILD with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_TAX_CLAIM_CHILD, PayConcepts.CONCEPT_TAX_CLAIM_CHILD.ToString())
    static member REFCON_TAX_ADVANCE_BASE with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_TAX_ADVANCE_BASE, PayConcepts.CONCEPT_TAX_ADVANCE_BASE.ToString())
    static member REFCON_TAX_ADVANCE with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_TAX_ADVANCE, PayConcepts.CONCEPT_TAX_ADVANCE.ToString())
    static member REFCON_TAX_RELIEF_PAYER with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_TAX_RELIEF_PAYER, PayConcepts.CONCEPT_TAX_RELIEF_PAYER.ToString())
    static member REFCON_TAX_RELIEF_DISABILITY with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_TAX_RELIEF_DISABILITY, PayConcepts.CONCEPT_TAX_RELIEF_DISABILITY.ToString())
    static member REFCON_TAX_RELIEF_STUDYING with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_TAX_RELIEF_STUDYING, PayConcepts.CONCEPT_TAX_RELIEF_STUDYING.ToString())
    static member REFCON_TAX_RELIEF_CHILD with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_TAX_RELIEF_CHILD, PayConcepts.CONCEPT_TAX_RELIEF_CHILD.ToString())
    static member REFCON_TAX_BONUS_CHILD with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_TAX_BONUS_CHILD, PayConcepts.CONCEPT_TAX_BONUS_CHILD.ToString())
    static member REFCON_TAX_ADVANCE_FINAL with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_TAX_ADVANCE_FINAL, PayConcepts.CONCEPT_TAX_ADVANCE_FINAL.ToString())
    static member REFCON_TAX_WITHHOLD_BASE with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_TAX_WITHHOLD_BASE, PayConcepts.CONCEPT_TAX_WITHHOLD_BASE.ToString())
    static member REFCON_TAX_WITHHOLD with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_TAX_WITHHOLD, PayConcepts.CONCEPT_TAX_WITHHOLD.ToString())
    static member REFCON_INCOME_GROSS with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_INCOME_GROSS, PayConcepts.CONCEPT_INCOME_GROSS.ToString())
    static member REFCON_INCOME_NETTO with get() = new CodeNameRefer(uint32 PayConcepts.CONCEPT_INCOME_NETTO, PayConcepts.CONCEPT_INCOME_NETTO.ToString())
