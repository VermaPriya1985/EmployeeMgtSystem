<div class="Box-body px-5 pb-5">
        <article class="markdown-body entry-content container-lg" itemprop="text"><h2><a id="user-content-gardenit" class="anchor" aria-hidden="true" href="#gardenit"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>GardenIt</h2>
<p>GardenIt is an online garden management system that lets you keep track of your house plants and see how often you need to water them</p>
<p>It is intended for educational purposes to demonstrate how to build a full-stack web application. The application is built using .NET Core 3.1 and C#.</p>
<h2><a id="user-content-components" class="anchor" aria-hidden="true" href="#components"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>Components</h2>
<h3><a id="user-content-engine" class="anchor" aria-hidden="true" href="#engine"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>Engine</h3>
<p>The engine, or logic layer of the application, consists of 'Plants', and 'Waterings' models. Each plant can have many waterings associated with it. Any time the user waters a plant, a 'Watering' instance is added to the plant's collection of waterings.</p>
<p>The NextWateringDate for a plant is calculated by taking the most recent watering date, and adding the DaysBetweenWaterings value onto it. This is displayed to the user.</p>
<p>The 'Garden' class is the main engine class. This is where the main actions of the application are defined. This includes CRUD operations on the Plant object, as well as the ability to Water a plant.</p>
<h3><a id="user-content-database" class="anchor" aria-hidden="true" href="#database"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>Database</h3>
<p>The application uses a Postgres database provisioned using a free tier of <a href="https://www.elephantsql.com/" rel="nofollow">ElephantSQL</a>. There are separate databases for dev and prod. Entity Framework Core is used for the database and a storage interface layer sits on top of the EF layer.</p>
<p>The Garden engine class specifies only the interface, and is not tied to the EF Core implementation, so it can be swapped out without affecting the logic.</p>
<h3><a id="user-content-views-and-controllers" class="anchor" aria-hidden="true" href="#views-and-controllers"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>Views and Controllers</h3>
<p>The operations exposed to the user include the CRUD operations on a plant as well as the ability to water a plant. This is all handled from the PlantController.</p>
<p>The Form.cshtml view is re-used for both creation and editing, and is toggled using a trigger on the ViewBag.</p>
<h3><a id="user-content-identity" class="anchor" aria-hidden="true" href="#identity"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>Identity</h3>
<p>The identity was scaffolded using the .NET core identity tool. It largely uses the default setup, however, integration with SendGrid has been added for confirming email addresses on registration.</p>
<p>The following command can be used to generate the custom identity pages:
<code>dotnet aspnet-codegenerator identity -dc GardenIt.Models.Storage.ApplicationDbContext --files "Account.Register;Account.Login;Account.RegisterConfirmation"</code></p>
<h2><a id="user-content-deploying" class="anchor" aria-hidden="true" href="#deploying"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>Deploying</h2>
<p>To deploy this application:</p>
<ul>
<li>Create an App Service in Azure</li>
<li>Ensure the Azure App Service extension is installed in VS Code</li>
<li>Ensure the extension is synced to your Azure account</li>
<li>Create a publish folder: <code>dotnet publish -c Release -o ./publish</code></li>
<li>Deploy by right clicking on the publish folder and deploying to the web app</li>
</ul>
<p>The application is available at: <a href="https://gardenit.azurewebsites.net" rel="nofollow">https://gardenit.azurewebsites.net</a></p>
<h2><a id="user-content-resources" class="anchor" aria-hidden="true" href="#resources"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>Resources</h2>
<p><a href="https://www.youtube.com/watch?v=QpJvqiHl1Fo" rel="nofollow">Uploading images tutorial</a></p>
<p><a href="https://docs.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-3.1&amp;tabs=netcore-cli" rel="nofollow">Scaffolding Identity</a></p>
<p><a href="https://docs.microsoft.com/en-us/aspnet/core/security/authentication/accconfirm?view=aspnetcore-3.1&amp;tabs=visual-studio" rel="nofollow">SendGrid integration</a></p>
<p><a href="https://andrewlock.net/customising-aspnetcore-identity-without-editing-the-pagemodel/" rel="nofollow">Andrew Lock blog</a></p>
</article>
      </div>


