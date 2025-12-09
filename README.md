# FilteringNumbers: پیاده‌سازی استراتژی فیلترینگ با استفاده از Enumerable

این پروژه نمونه‌ای از پیاده‌سازی الگوی **Strategy** برای فیلتر کردن داده‌ها، با استفاده از قابلیت‌های **Generic** و **Extension Methods** در C# و بهینه‌سازی با **`yield return`** است.

## 🎯 هدف پروژه

هدف اصلی، جدا کردن منطق فیلترینگ از منطق اصلی سرویس (Service Layer) با استفاده از یک Interface است و همچنین نمایش نحوه بهبود کارایی با استفاده از `IEnumerable` و بازگشت تدریجی داده‌ها (`yield return`).

## ⚙️ ویژگی‌ها و تکنیک‌های استفاده شده

1.  **الگوی Strategy:** تعریف `IFilter<T>` برای کپسوله کردن قوانین فیلتر.
2.  **Generic بودن (Generics):** تعریف Interface فیلتر به صورت `IFilter<T>` برای قابلیت استفاده مجدد با انواع داده‌های مختلف (در این پروژه بر روی `int` تمرکز شده است).
3.  **Extension Methods:** پیاده‌سازی متد `FilterNumbers` به عنوان یک Extension Method روی `IEnumerable<T>` برای خوانایی بالاتر کد (مثلاً: `numbers.FilterNumbers(filter)`).
4.  **Lazy Evaluation با `yield return`:**
    *   در متد `ReadNumbersFromUser`، از `yield return` استفاده شده است تا اعداد به محض وارد شدن توسط کاربر و معتبر بودن، برگردانده شوند و نیازی به نگهداری کل لیست در حافظه نباشد.
    *   در متد `FilterNumbers`، از `yield return` استفاده شده است تا فیلتر به صورت تنبل (Lazy) اعمال شود و داده‌ها به محض آماده شدن فیلتر شوند.

## 🛠️ ساختار اصلی کد

پروژه به سه بخش اصلی تقسیم می‌شود:

### 1. تعریف استراتژی‌ها (`FilterStrategyByEnumerable`)

این بخش شامل تعریف Interface اصلی و پیاده‌سازی‌های خاص است:

*   `IFilter<T>`: رابط اصلی برای تمام استراتژی‌های فیلتر.
*   `EvenAndGreaterThanTenFilter`: یک پیاده‌سازی نمونه برای فیلتر کردن اعداد زوج بزرگتر از ۱۰.

### 2. سرویس اصلی (`NumberService`)

این کلاس متدهایی را ارائه می‌دهد که منطق اصلی برنامه را مدیریت می‌کنند:

*   `ReadNumbersFromUser()`: متدی که با استفاده از **`yield return`** اعداد را از کنسول می‌خواند.
*   `PrintNumbers()`: متدی برای نمایش نتیجه نهایی.

### 3. Extension Methods

*   `FilterNumbers<T>(this IEnumerable<T> numbers, IFilter<T> filter)`: متد Extension که منطق اصلی فیلتر کردن را با استفاده از `yield return` پیاده‌سازی می‌کند.
