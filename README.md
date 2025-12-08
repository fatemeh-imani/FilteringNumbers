🚀 FilteringNumbers – A Clean & Testable Filtering System

A small but powerful project demonstrating:
✔ Generic Programming
✔ Object-Based Processing
✔ Delegates & Func
✔ Input Parsers
✔ Clean Architecture
✔ Unit Testing with Fake IO

🧩 Overview

این پروژه یک سیستم انعطاف‌پذیر برای دریافت ورودی، تبدیل آن به نوع صحیح، اعمال فیلتر، و نمایش نتیجه است.
همه‌چیز به صورت کاملاً جدا از هم، قابل توسعه و قابل تست طراحی شده است.

📁 Project Architecture
FilteringNumbers/
├── FilterConditions/   → تعریف شروط فیلتر
├── FilterParsers/      → تبدیل string به نوع موردنظر (int/double/string)
├── NumberService/      → قلب سیستم: ورودی، فیلتر، خروجی
├── IUserIO & FakeIO/   → جداسازی Console + شبیه‌سازی تست
└── Tests/              → تست کل سیستم

🎯 Why This Project Matters?
🔹 Separation of Concerns (SOLID)

همه چیز در کلاس مخصوص خودش است:

شرط‌ها → FilterConditions

تبدیل ورودی → FilterParsers

منطق اصلی → NumberService

IO → قابل تعویض و تست‌پذیر

🔹 Two Approaches to Filtering
Approach	Description	Use Case
Object-Based	ورودی‌ها از نوع object هستند و در زمان اجرا نوع بررسی می‌شود	وقتی نوع داده مشخص نیست
Generic-Based	فیلتر مخصوص یک نوع T اعمال می‌شود	سریع‌تر، تمیزتر، Type-Safe
🔹 Delegate & Func

پردازش ورودی و اعمال شرط‌ها با ارسال توابع انجام می‌شود:

Func<string, (bool Success, T Value)> parser
Func<T, bool> filter


این یعنی NumberService هیچ اطلاعی از نوع داده ندارد → فقط توابع را اجرا می‌کند.

🔹 Fully Testable

به کمک FakeConsoleUserIO توانستیم:

بدون Console واقعی تست بزنیم

ورودی‌ها را شبیه‌سازی کنیم

خروجی‌ها را ضبط کنیم

رفتار برنامه را دقیق بررسی کنیم

🧪 Unit Tests
✔ شامل تست‌های:

فیلتر Object-Based

فیلتر Generic-Based

عملکرد Parsers

خواندن ورودی

چاپ خروجی

رفتار IO

✔ تست IO با Fake IO

نمونه:

var fakeIO = new FakeConsoleUserIO(new[] { "3.5", "7.1", "done" });
ConsoleUserIO.OverrideForTest(fakeIO);

var result = NumberService.ReadItemsFromUserList(FilterParsers.DoubleParser);

🔧 How Filtering Works?
1️⃣ دریافت داده از کاربر

با کمک Parsers:

اگر int بود → تبدیل به int

اگر double بود → تبدیل به double

اگر string بود → همان رشته ذخیره می‌شود

2️⃣ اعمال شرط

با Func<T, bool> یا Func<object, bool>

مثال شرط‌ها:
item => item > 10
item => item is string

3️⃣ خروجی

تمام آیتم‌های فیلترشده چاپ می‌شوند.

🧠 Why Parsers and FilterConditions?
🟦 FilterConditions

برای اینکه شرط‌ها از منطق برنامه جدا باشند.
افزودن شرط جدید فقط افزودن یک متد یا delegate جدید است.

🟩 FilterParsers

برای اینکه NumberService وابسته به TryParseها نباشد.
نوع ورودی با تابع تعیین می‌شود، نه با کد ثابت.

📦 Example Workflow
User → enters "5", "12", "hello", "20", "done"
Parser → identifies int/double/string
Filter → removes items <= 10
Output  → 12, 20, "hello"