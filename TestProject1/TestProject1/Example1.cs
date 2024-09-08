using Microsoft.Playwright;

namespace PlaywrightTests;

[TestFixture]
public class TestNodeExes1 : PlaywrightTest
{
    private IAPIRequestContext Request = null!;

    [Test]
    public async Task Test1()
    {
        await Request.GetAsync("https://github.com/cmealex/pw2024.git");
    }

    [Test]
    public async Task Test2()
    {
        await Request.GetAsync("https://github.com/cmealex/pw2024.git");
    }

    [SetUp]
    public async Task SetUpAPITesting()
    {
        await CreateAPIRequestContext();
    }

    private async Task CreateAPIRequestContext()
    {
        Request = await Playwright.APIRequest.NewContextAsync(new()
        {
        });
    }

    [TearDown]
    public async Task TearDownAPITesting()
    {
        await Request.DisposeAsync();
    }

}

public class TestNodeExes2 : PlaywrightTest
{
    private IAPIRequestContext Request = null!;

    [Test]
    public async Task Test1()
    {
        await Request.GetAsync("https://github.com/cmealex/pw2024.git");
    }

    [Test]
    public async Task Test2()
    {
        await Request.GetAsync("https://github.com/cmealex/pw2024.git");
    }

    [SetUp]
    public async Task SetUpAPITesting()
    {
        await CreateAPIRequestContext();
    }

    private async Task CreateAPIRequestContext()
    {
        Request = await Playwright.APIRequest.NewContextAsync(new()
        {
        });
    }

    [TearDown]
    public async Task TearDownAPITesting()
    {
        await Request.DisposeAsync();
    }

}


public class TestNodeExes3 : PlaywrightTest
{
    private IAPIRequestContext Request = null!;

    [Test]
    public async Task Test1()
    {
        await Request.GetAsync("https://github.com/cmealex/pw2024.git");
    }

    [Test]
    public async Task Test2()
    {
        await Request.GetAsync("https://github.com/cmealex/pw2024.git");
    }

    [SetUp]
    public async Task SetUpAPITesting()
    {
        await CreateAPIRequestContext();
    }

    private async Task CreateAPIRequestContext()
    {
        Request = await Playwright.APIRequest.NewContextAsync(new()
        {
        });
    }

    [TearDown]
    public async Task TearDownAPITesting()
    {
        await Request.DisposeAsync();
    }

}


public class TestNodeExes4 : PlaywrightTest
{
    private IAPIRequestContext Request = null!;

    [Test]
    public async Task Test1()
    {
        await Request.GetAsync("https://github.com/cmealex/pw2024.git");
    }

    [Test]
    public async Task Test2()
    {
        await Request.GetAsync("https://github.com/cmealex/pw2024.git");
    }

    [SetUp]
    public async Task SetUpAPITesting()
    {
        await CreateAPIRequestContext();
    }

    private async Task CreateAPIRequestContext()
    {
        Request = await Playwright.APIRequest.NewContextAsync(new()
        {
        });
    }

    [TearDown]
    public async Task TearDownAPITesting()
    {
        await Request.DisposeAsync();
    }

}


public class TestNodeExes10 : PlaywrightTest
{
    private IAPIRequestContext Request = null!;

    [Test]
    public async Task Test1()
    {
        await Request.GetAsync("https://github.com/cmealex/pw2024.git");
    }

    [Test]
    public async Task Test2()
    {
        await Request.GetAsync("https://github.com/cmealex/pw2024.git");
    }

    [SetUp]
    public async Task SetUpAPITesting()
    {
        await CreateAPIRequestContext();
    }

    private async Task CreateAPIRequestContext()
    {
        Request = await Playwright.APIRequest.NewContextAsync(new()
        {
        });
    }

    [TearDown]
    public async Task TearDownAPITesting()
    {
        await Request.DisposeAsync();
    }

}


public class TestNodeExes5 : PlaywrightTest
{
    private IAPIRequestContext Request = null!;

    [Test]
    public async Task Test1()
    {
        await Request.GetAsync("https://github.com/cmealex/pw2024.git");
    }

    [Test]
    public async Task Test2()
    {
        await Request.GetAsync("https://github.com/cmealex/pw2024.git");
    }

    [SetUp]
    public async Task SetUpAPITesting()
    {
        await CreateAPIRequestContext();
    }

    private async Task CreateAPIRequestContext()
    {
        Request = await Playwright.APIRequest.NewContextAsync(new()
        {
        });
    }

    [TearDown]
    public async Task TearDownAPITesting()
    {
        await Request.DisposeAsync();
    }

}


public class TestNodeExes6 : PlaywrightTest
{
    private IAPIRequestContext Request = null!;

    [Test]
    public async Task Test1()
    {
        await Request.GetAsync("https://github.com/cmealex/pw2024.git");
    }

    [Test]
    public async Task Test2()
    {
        await Request.GetAsync("https://github.com/cmealex/pw2024.git");
    }

    [SetUp]
    public async Task SetUpAPITesting()
    {
        await CreateAPIRequestContext();
    }

    private async Task CreateAPIRequestContext()
    {
        Request = await Playwright.APIRequest.NewContextAsync(new()
        {
        });
    }

    [TearDown]
    public async Task TearDownAPITesting()
    {
        await Request.DisposeAsync();
    }

}


public class TestNodeExes7 : PlaywrightTest
{
    private IAPIRequestContext Request = null!;

    [Test]
    public async Task Test1()
    {
        await Request.GetAsync("https://github.com/cmealex/pw2024.git");
    }

    [Test]
    public async Task Test2()
    {
        await Request.GetAsync("https://github.com/cmealex/pw2024.git");
    }

    [SetUp]
    public async Task SetUpAPITesting()
    {
        await CreateAPIRequestContext();
    }

    private async Task CreateAPIRequestContext()
    {
        Request = await Playwright.APIRequest.NewContextAsync(new()
        {
        });
    }

    [TearDown]
    public async Task TearDownAPITesting()
    {
        await Request.DisposeAsync();
    }

}


public class TestNodeExes8 : PlaywrightTest
{
    private IAPIRequestContext Request = null!;

    [Test]
    public async Task Test1()
    {
        await Request.GetAsync("https://github.com/cmealex/pw2024.git");
    }

    [Test]
    public async Task Test2()
    {
        await Request.GetAsync("https://github.com/cmealex/pw2024.git");
    }

    [SetUp]
    public async Task SetUpAPITesting()
    {
        await CreateAPIRequestContext();
    }

    private async Task CreateAPIRequestContext()
    {
        Request = await Playwright.APIRequest.NewContextAsync(new()
        {
        });
    }

    [TearDown]
    public async Task TearDownAPITesting()
    {
        await Request.DisposeAsync();
    }

}


public class TestNodeExes9 : PlaywrightTest
{
    private IAPIRequestContext Request = null!;

    [Test]
    public async Task Test1()
    {
        await Request.GetAsync("https://github.com/cmealex/pw2024.git");
    }

    [Test]
    public async Task Test2()
    {
        await Request.GetAsync("https://github.com/cmealex/pw2024.git");
    }

    [SetUp]
    public async Task SetUpAPITesting()
    {
        await CreateAPIRequestContext();
    }

    private async Task CreateAPIRequestContext()
    {
        Request = await Playwright.APIRequest.NewContextAsync(new()
        {
        });
    }

    [TearDown]
    public async Task TearDownAPITesting()
    {
        await Request.DisposeAsync();
    }

}