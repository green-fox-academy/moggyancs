# There are 3 kind of fishes:
# - Clownfish, gains 1 gramm when feeded and has stripe color.
# - Tang, gains 1 gramms when feeded and can suffer short-term memory loss.
# - Koi, gains 2 gramms when feeded.
# Each fish has a name, weight, color and has a status and feed method.

# Create an aquarium and take care of your fishes.
# Create a method on the aquarium that feeds all the fishes in the aquarium:
# increases the weight of every fish with the amount of gramms they gain when feeded.
# Create a method on the aquarium that removes the big fishes.
# A big fish's weight is at least 11 gramms.
# The aquarium has a status method it should print the status for each fish.

fish_tank = Aquarium()

fish_tank.add(Koi("Nami", 9, "pink"))
fish_tank.add(Tang("Dory", 8, "blue", True))
fish_tank.add(Tang("Bubbles", 10, "yellow", False))
fish_tank.add(Clownfish("Nemo", 5, "orange", "white"))

print(fish_tank.status())

# Nami, weight: 9, color: pink
# Dory, weight: 8, color: blue, short-term memory loss: true
# Bubbles, weight: 10, color: yellow, short-term memory loss: false
# Nemo, weight: 5, color: orange, stripe color: white

fish_tank.feed()
fish_tank.remove_oversized_fishes()

print(fish_tank.status())

# Dory, weight: 9, color: blue, short-term memory loss: true
# Nemo, weight: 6, color: orange, stripe color: white
