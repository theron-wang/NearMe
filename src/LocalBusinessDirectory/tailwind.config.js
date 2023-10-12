/** @type {import('tailwindcss').Config} */

const defaultTheme = require('tailwindcss/defaultTheme')

module.exports = {
    content: [
        "./Pages/**/*.{razor,cshtml}",
        "./*.razor",
        "./Shared/**/*.razor"
    ],
  theme: {
      extend: {
          fontFamily: {
              'default': ['Inter', 'Helvetica', 'Arial', 'sans-serif'],
              'display': ['Josefin Sans', 'Helvetica', 'Arial', 'sans-serif']
          },
          minWidth: {
              '1/4': "25%",
              '1/2': "50%",
              ...defaultTheme.spacing
          },
          minHeight: {
              ...defaultTheme.spacing
          },
          maxWidth: {
              '3/4': "75%",
              ...defaultTheme.spacing
          },
          maxHeight: {
              '3/4': "75%"
          }
        },
  },
  plugins: [],
}

