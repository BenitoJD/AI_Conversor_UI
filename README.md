
This project aims to provide a clean, minimal UI layer that can be bound to a local or hosted AI service for various “conversion” tasks, keeping the front end simple and deployment‑friendly.
The repository structure and setup steps are intentionally straightforward so the interface can be tested as static pages or paired with a small service as the backend matures.

Features (template)


Simple HTML/CSS layout focused on usability and clarity for conversion workflows, suitable for static hosting or local preview with a live server.

Configurable API endpoint (e.g., environment or small config script) so the UI can target different backends without code changes.

Basic request/response panel that can display results, errors, and optional citations or logs returned by the backend.

Extensible component structure to add new conversion modes or models without rewriting the core UI.

Getting started


Prerequisites: A modern browser; for local development, a simple static server or IDE extension (e.g., VS Code Live Server) is enough to preview HTML/CSS/JS changes.

Clone the repository, open it in the preferred editor, and preview index.html with a local server to avoid CORS issues when calling any external API.

Quick start (local)


Clone: git clone and open the folder in an editor that supports a local static server preview.

Run: start a local server to serve the HTML (e.g., any static server) and verify UI loads without backend calls first.

Connect: set the API endpoint in configuration (see Configuration) and test a simple conversion request.

Configuration


Create a small configuration (e.g., config.js or environment injection) to set API_BASE_URL, model or mode defaults, and optional headers or keys for the downstream service.

Use development and production variants to separate local endpoints from hosted gateways, keeping secrets out of source control and avoiding accidental production calls during local tests.

Usage
Select a conversion mode in the UI, provide input or upload a file if applicable, then submit to send a request to the configured API_BASE_URL.

Inspect response panels for results and errors; if the backend returns citations, logs, or token usage, surface them in the UI for transparency and debugging.
