# RPG Gym Client

Angular TypeScript client application for RPG Gym

## Getting Started

### Prerequisites
- Node.js (v18 or higher)
- npm (v9 or higher)

### Installation

```bash
npm install
```

### Development Server

Run `npm start` for a dev server. Navigate to `http://localhost:4200/`. The application will automatically reload if you change any of the source files.

### Build

Run `npm build` to build the project. The build artifacts will be stored in the `dist/` directory.

### Running Unit Tests

Run `npm test` to execute the unit tests via [Karma](https://karma-runner.github.io).

### Running End-to-End Tests

Run `npm run e2e` to execute the end-to-end tests via a platform of your choice. To use this command, you need to first add a package that implements end-to-end testing capabilities.

## Project Structure

```
src/
├── app/
│   ├── core/
│   │   └── services/        # Core services
│   ├── features/            # Feature modules
│   ├── shared/              # Shared components
│   ├── app.component.ts     # Root component
│   ├── app.routes.ts        # Routes
│   └── app.config.ts        # App configuration
├── environments/            # Environment configs
├── styles.css               # Global styles
├── index.html               # Root HTML
└── main.ts                  # Bootstrap
```

## API Integration

The `ApiService` in `src/app/core/services/api.service.ts` handles all HTTP communication with the backend API.

Default API endpoint: `http://localhost:5000/api`

## License

MIT
