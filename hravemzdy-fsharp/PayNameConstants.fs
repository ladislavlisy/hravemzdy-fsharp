namespace PayrollLibrary

type PayNameGroups() = 
    static member VPAYGRP_UNKNOWN with get() = "VPAYGRP_NULL"
    static member HPAYGRP_UNKNOWN with get() = "HPAYGRP_NULL"
    static member VPAYGRP_SCHEDULE with get() = "VPAYGRP_SCHEDULE"
    static member VPAYGRP_PAYMENTS with get() = "VPAYGRP_PAYMENTS"
    static member VPAYGRP_TAX_SOURCE with get() = "VPAYGRP_TAX_SOURCE"
    static member VPAYGRP_TAX_RESULT with get() = "VPAYGRP_TAX_RESULT"
    static member VPAYGRP_INS_RESULT with get() = "VPAYGRP_INS_RESULT"
    static member VPAYGRP_TAX_INCOME with get() = "VPAYGRP_TAX_INCOME"
    static member VPAYGRP_INS_INCOME with get() = "VPAYGRP_INS_INCOME"
    static member VPAYGRP_SUMMARY with get() = "VPAYGRP_SUMMARY"

